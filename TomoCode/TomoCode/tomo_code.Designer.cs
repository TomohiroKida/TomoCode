namespace TomoCode
{
    partial class TomoCode
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TomoCode));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.検索FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置換HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行へ移動GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorColor = new System.Windows.Forms.ToolStripMenuItem();
            this.EditColorSnow = new System.Windows.Forms.ToolStripMenuItem();
            this.EditColorTea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tool_strip_status_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFail,
            this.menuEdit,
            this.menuOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFail
            // 
            this.menuFail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuNew,
            this.menuSaveAs,
            this.menuSaveName,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFail.Name = "menuFail";
            this.menuFail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuFail.Size = new System.Drawing.Size(66, 20);
            this.menuFail.Text = "ファイル(&F)";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(215, 22);
            this.menuOpen.Text = "開く(&O)";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(215, 22);
            this.menuNew.Text = "新規作成(&N)";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Enabled = false;
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSaveAs.Size = new System.Drawing.Size(215, 22);
            this.menuSaveAs.Text = "上書き保存(&S)";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuSaveName
            // 
            this.menuSaveName.Name = "menuSaveName";
            this.menuSaveName.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuSaveName.Size = new System.Drawing.Size(215, 22);
            this.menuSaveName.Text = "名前をつけて保存(&A)";
            this.menuSaveName.Click += new System.EventHandler(this.menuSaveName_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuExit.Size = new System.Drawing.Size(215, 22);
            this.menuExit.Text = "エディターの終了(&X)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.toolStripSeparator4,
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.menuDelete,
            this.toolStripSeparator2,
            this.検索FToolStripMenuItem,
            this.置換HToolStripMenuItem,
            this.行へ移動GToolStripMenuItem,
            this.toolStripSeparator3,
            this.menuAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(43, 20);
            this.menuEdit.Text = "編集";
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.Size = new System.Drawing.Size(136, 22);
            this.menuUndo.Text = "元に戻す(&U)";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.Size = new System.Drawing.Size(136, 22);
            this.menuCut.Text = "切り取り(&T)";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(136, 22);
            this.menuCopy.Text = "コピー(&C)";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(136, 22);
            this.menuPaste.Text = "貼り付け(&V)";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(136, 22);
            this.menuDelete.Text = "削除(&L)";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // 検索FToolStripMenuItem
            // 
            this.検索FToolStripMenuItem.Name = "検索FToolStripMenuItem";
            this.検索FToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.検索FToolStripMenuItem.Text = "検索(&F)";
            // 
            // 置換HToolStripMenuItem
            // 
            this.置換HToolStripMenuItem.Name = "置換HToolStripMenuItem";
            this.置換HToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.置換HToolStripMenuItem.Text = "置換(&H)";
            // 
            // 行へ移動GToolStripMenuItem
            // 
            this.行へ移動GToolStripMenuItem.Name = "行へ移動GToolStripMenuItem";
            this.行へ移動GToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.行へ移動GToolStripMenuItem.Text = "行へ移動(&G)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // menuAll
            // 
            this.menuAll.Name = "menuAll";
            this.menuAll.Size = new System.Drawing.Size(136, 22);
            this.menuAll.Text = "全て選択(&A)";
            this.menuAll.Click += new System.EventHandler(this.menuAll_Click);
            // 
            // menuOption
            // 
            this.menuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditorColor,
            this.menuVersion});
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(79, 20);
            this.menuOption.Text = "オプション(&O)";
            // 
            // menuEditorColor
            // 
            this.menuEditorColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditColorSnow,
            this.EditColorTea});
            this.menuEditorColor.Name = "menuEditorColor";
            this.menuEditorColor.Size = new System.Drawing.Size(152, 22);
            this.menuEditorColor.Text = "配色テ―マ";
            // 
            // EditColorSnow
            // 
            this.EditColorSnow.Checked = true;
            this.EditColorSnow.CheckOnClick = true;
            this.EditColorSnow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EditColorSnow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditColorSnow.Name = "EditColorSnow";
            this.EditColorSnow.Size = new System.Drawing.Size(152, 22);
            this.EditColorSnow.Text = "雪";
            this.EditColorSnow.CheckedChanged += new System.EventHandler(this.EditColor_Click);
            // 
            // EditColorTea
            // 
            this.EditColorTea.CheckOnClick = true;
            this.EditColorTea.Name = "EditColorTea";
            this.EditColorTea.Size = new System.Drawing.Size(152, 22);
            this.EditColorTea.Text = "抹茶";
            this.EditColorTea.CheckedChanged += new System.EventHandler(this.EditColor_Click);
            // 
            // menuVersion
            // 
            this.menuVersion.Name = "menuVersion";
            this.menuVersion.Size = new System.Drawing.Size(152, 22);
            this.menuVersion.Text = "バージョン情報";
            this.menuVersion.Click += new System.EventHandler(this.menuVersion_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "SFLファイル(*.sfl)|*.sfl|SECファイル(*.sec)|*.sec|テキストファイル(*.txt)|*.txt|全てのファイル(*.*)|*.*";
            this.openFileDialog.ShowReadOnly = true;
            this.openFileDialog.Title = "ファイルを開く";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "SFLファイル(*.sfl)|*.sfl|SECファイル(*.sec)|*.sec|テキストファイル(*.txt)|*.txt|全てのファイル(*.*)|*.*";
            this.saveFileDialog.Title = "名前を付けて保存";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_status_label1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tool_strip_status_label1
            // 
            this.tool_strip_status_label1.Name = "tool_strip_status_label1";
            this.tool_strip_status_label1.Size = new System.Drawing.Size(38, 17);
            this.tool_strip_status_label1.Text = "status";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Snow;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(584, 452);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TomoCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 498);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TomoCode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TomoCode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFail;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem menuEditorColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuSaveName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tool_strip_status_label1;
        private System.Windows.Forms.ToolStripMenuItem menuVersion;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 検索FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置換HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行へ移動GToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuAll;
        private System.Windows.Forms.ToolStripMenuItem EditColorSnow;
        private System.Windows.Forms.ToolStripMenuItem EditColorTea;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}



