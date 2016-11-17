using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TomoCode
{
    public partial class TomoCode : Form
    {
        // ダーティーフラグ
        private bool dirty_flag = false;
        // 読み取り専用フラグ
        private bool read_only_flag = false;
        // 編集中のファイルパス
        private string edit_file_path = "";
        // 配色テーマの情報リスト
        private List<ToolStripMenuItem> edit_color_list = new List<ToolStripMenuItem>();

        // ベーシック用
        public TomoCode()
        {
            InitializeComponent();
        }

        // コマンドライン用
        public TomoCode(string arg)
        {
            InitializeComponent();
            edit_file_path = arg;

            // ファイルが存在するか確認
            if (File.Exists(edit_file_path))
            {
                if (System.IO.File.Exists(edit_file_path))
                {
                    richTextBox1.Text = File.ReadAllText(edit_file_path, Encoding.Default);
                }

                this.Text = GetFileNameString(arg, '\\');
                SetDirty(false);
            }
            else
            {
                //ファイルの読み込みでエラーが発生した場合に Exception の内容を表示
                MessageBox.Show(string.Format("ファイルが見当たりません．\n", edit_file_path), "ファイルを開く（コマンドライン）", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ファイルメニュー関連のイベントハンドラ
        #region file menu handlers

        /// <summary>
        /// ダーティーフラグと上書きメニューアイテムの有効無効処理
        /// </summary>
        /// <param name="flag"></param>
        private void SetDirty(bool flag)
        {
            dirty_flag = false;
            menuSaveAs.Enabled = (read_only_flag) ? false : flag;
        }

        /// <summary>
        /// 保存していない編集中のテキストがある場合に確認するための関数 
        /// </summary>
        /// <param name="msgbox_title"></param>
        /// <returns></returns>
        private bool ConfirmDestrucitonText(string msgbox_title)
        {
            const string MSG_BOX_STRING = "ファイルは保存されていません．\n\n編集中のテキストは破棄されます．\n\nよろしいですか？";
            if (!dirty_flag)
                return true;
            return (MessageBox.Show(MSG_BOX_STRING, msgbox_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        /// <summary>
        /// テキストボックスの内容が変更後のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            SetDirty(true);
        }

        /// <summary>
        /// [新規作成]クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuNew_Click(object sender, EventArgs e)
        {
            const string MSG_BOX_TITLE = "ファイルの新規作成";
            if (ConfirmDestrucitonText(MSG_BOX_TITLE))
            {
                this.Text = "新規ファイル";
                richTextBox1.Clear();
                edit_file_path = "";
                SetDirty(false);
            }
        }

        /// <summary>
        /// ステータスバーに保存日時を表示
        /// </summary>
        private void ShowSaveDateTime()
        {
            const string STATUS_STRING = "に保存しました．";
            tool_strip_status_label1.Text = System.DateTime.Now.ToString("yyyy/MM/dd/ HH:mm:ss") + STATUS_STRING;
        }

        /// <summary>
        /// [上書き保存]クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            const string MSGBOX_TITLE = "ファイルの上書き保存";

            if (File.Exists(edit_file_path))
            {
                try
                {
                    File.WriteAllText(edit_file_path, richTextBox1.Text, Encoding.Default);
                    SetDirty(false);

                    ShowSaveDateTime();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                string MSG_BOX_STRING = "ファイル\"" + edit_file_path + "\" のパスは正しくありません．\n\nディレクトリが存在するか確認してください．";
                MessageBox.Show(MSG_BOX_STRING, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// [名前をつけて保存]クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSaveName_Click(object sender, EventArgs e)
        {
            //ファイルが新規作成だった場合の名前
            const string NEW_FILE_NAME = "新規テキストファイル.sfl";

            //編集中のファイルのフルパスからファイル名だけを取得
            string fileNameString = GetFileNameString(edit_file_path, '\\');

            //ファイル名が空白であった場合は　"新規テキストファイル.txt" をセット
            saveFileDialog.FileName = (fileNameString == "") ? NEW_FILE_NAME : fileNameString;
            saveFileDialog.ShowDialog(this);
        }

        //フルパスからファイル名のみを取り出す関数
        private string GetFileNameString(string file_path, char separate_char)
        {
            try
            {
                string[] strArray = file_path.Split(separate_char);
                return strArray[strArray.Length - 1];
            }
            catch
            { return ""; }
        }

        /// <summary>
        /// [開く]クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        /// <summary>
        /// ファイルを開く処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            const string TITLE_EXTN_ReadOnly = " (読み取り専用)";
            const string MSGBOX_TITLE = "ファイル オープン";

            //選択されたファイルのパスを取得
            edit_file_path = openFileDialog.FileName;



            //ファイルダイアログで読み取り専用が選択されたかどうかの値を取得
            read_only_flag = openFileDialog.ReadOnlyChecked;

            //読み取り専用で開いた場合にタイトル(ファイル名)に "読み取り専用" の文字をつける
            this.Text = (read_only_flag)
                 ? openFileDialog.SafeFileName + TITLE_EXTN_ReadOnly : openFileDialog.SafeFileName;



            //ダーティーフラグのリセット
            SetDirty(false);


            try
            {
                //テキストファイルの内容をテキストボックスにロード
                richTextBox1.Text = File.ReadAllText(edit_file_path, Encoding.Default);
            }
            catch (Exception ex)
            {
                //ファイルの読み込みでエラーが発生した場合に Exception の内容を表示
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ファイルを保存する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            const string MSGBOX_TITLE = "名前を付けて保存";

            //ファイルダイアログで指定された保存先パスを取得
            edit_file_path = saveFileDialog.FileName;
            try
            {
                //ファイルの書き込み
                File.WriteAllText(edit_file_path, richTextBox1.Text, Encoding.Default);

                //ファイル名をウィンドウのタイトルに設定
                this.Text = GetFileNameString(edit_file_path, '\\');

                //ダーティーフラグのリセット
                SetDirty(false);

                //ステータスバーに保存日時を表示
                ShowSaveDateTime();
            }
            catch (Exception ex)
            {
                //エラー発生の際に Exception の内容を表示
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// [終了]メニュークリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion// file menu handlers


        // 編集メニュー関連のイベントハンドラ
        #region edit menu handlers

        // [元に戻す]メニュークリック
        private void menuUndo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        // [切り取り]メニュークリック
        private void menuCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        // [コピー]メニュークリック
        private void menuCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
        }

        // [貼り付け]メニュークリック
        private void menuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
        }

        // [削除]メニュークリック
        private void menuDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            Clipboard.Clear();
        }

        // [全て選択]メニュークリック
        private void menuAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        #endregion// edit menu handlers 

        // オプションメニュー関連のイベントハンドラ
        #region option menu handlers
        private void EditColor_Click(object sender, EventArgs e)
        {

            // チェックを入れて選択したとき
            if (((ToolStripMenuItem)sender).Checked)
                // 白
                if (((ToolStripMenuItem)sender).Name == EditColorSnow.Name)
                {
                    EditColorTea.Checked = false;
                    richTextBox1.BackColor = Color.Snow;
                    richTextBox1.ForeColor = Color.Black;
                }
                // 黒
                else if (((ToolStripMenuItem)sender).Name == EditColorTea.Name)
                {
                    EditColorSnow.Checked = false;
                    richTextBox1.BackColor = Color.FromArgb(0,64,64);
                    richTextBox1.ForeColor = Color.FromArgb(104,192,152);
                }

        }


        #region version infomation
        /// <summary>
        /// バージョン情報
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuVersion_Click(object sender, EventArgs e)
        {
            const string MSGBOX_TITLE = "バージョン情報";
            const string MSGBOX_TEXT = "TomoCode: ver1.0 (Alpha版) \n\n最終更新日: 2016/10/06";

            // バージョンを表示
            MessageBox.Show(this, MSGBOX_TEXT, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion// version infomation

        #endregion// option menu handlers

       
    }
}