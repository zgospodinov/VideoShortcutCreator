namespace VideoShortcutCreator.Ui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetMoviePath = new System.Windows.Forms.Button();
            this.txtBoxMoviesPath = new System.Windows.Forms.TextBox();
            this.btnDownloadSubtitles = new System.Windows.Forms.Button();
            this.настрийкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.директорияФилмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chkIsSeries = new System.Windows.Forms.CheckBox();
            this.chkUseRealName = new System.Windows.Forms.CheckBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShortcuts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVideoDirectory = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetMoviePath
            // 
            this.btnGetMoviePath.Location = new System.Drawing.Point(552, 60);
            this.btnGetMoviePath.Name = "btnGetMoviePath";
            this.btnGetMoviePath.Size = new System.Drawing.Size(112, 30);
            this.btnGetMoviePath.TabIndex = 7;
            this.btnGetMoviePath.Text = "Папка";
            this.btnGetMoviePath.UseVisualStyleBackColor = true;
            this.btnGetMoviePath.Click += new System.EventHandler(this.btnGetMoviePath_Click);
            // 
            // txtBoxMoviesPath
            // 
            this.txtBoxMoviesPath.Location = new System.Drawing.Point(163, 62);
            this.txtBoxMoviesPath.Name = "txtBoxMoviesPath";
            this.txtBoxMoviesPath.Size = new System.Drawing.Size(383, 22);
            this.txtBoxMoviesPath.TabIndex = 0;
            // 
            // btnDownloadSubtitles
            // 
            this.btnDownloadSubtitles.Location = new System.Drawing.Point(163, 194);
            this.btnDownloadSubtitles.Name = "btnDownloadSubtitles";
            this.btnDownloadSubtitles.Size = new System.Drawing.Size(152, 39);
            this.btnDownloadSubtitles.TabIndex = 8;
            this.btnDownloadSubtitles.Text = "Изтегли субтитри";
            this.btnDownloadSubtitles.UseVisualStyleBackColor = true;
            this.btnDownloadSubtitles.Click += new System.EventHandler(this.btnDownloadSubtitles_Click);
            // 
            // настрийкиToolStripMenuItem
            // 
            this.настрийкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.директорияФилмиToolStripMenuItem});
            this.настрийкиToolStripMenuItem.Name = "настрийкиToolStripMenuItem";
            this.настрийкиToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.настрийкиToolStripMenuItem.Text = "Настройки";
            // 
            // директорияФилмиToolStripMenuItem
            // 
            this.директорияФилмиToolStripMenuItem.Name = "директорияФилмиToolStripMenuItem";
            this.директорияФилмиToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.директорияФилмиToolStripMenuItem.Text = "Директория филми";
            this.директорияФилмиToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настрийкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chkIsSeries
            // 
            this.chkIsSeries.AutoSize = true;
            this.chkIsSeries.Location = new System.Drawing.Point(18, 160);
            this.chkIsSeries.Name = "chkIsSeries";
            this.chkIsSeries.Size = new System.Drawing.Size(79, 21);
            this.chkIsSeries.TabIndex = 6;
            this.chkIsSeries.Text = "Сериал";
            this.chkIsSeries.UseVisualStyleBackColor = true;
            // 
            // chkUseRealName
            // 
            this.chkUseRealName.AutoSize = true;
            this.chkUseRealName.Location = new System.Drawing.Point(18, 133);
            this.chkUseRealName.Name = "chkUseRealName";
            this.chkUseRealName.Size = new System.Drawing.Size(121, 21);
            this.chkUseRealName.TabIndex = 5;
            this.chkUseRealName.Text = "Истинско име";
            this.chkUseRealName.UseVisualStyleBackColor = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(163, 99);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(383, 22);
            this.txtBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Преименувай филм";
            // 
            // btnShortcuts
            // 
            this.btnShortcuts.Location = new System.Drawing.Point(18, 194);
            this.btnShortcuts.Name = "btnShortcuts";
            this.btnShortcuts.Size = new System.Drawing.Size(137, 39);
            this.btnShortcuts.TabIndex = 2;
            this.btnShortcuts.Text = "Създай пряк път";
            this.btnShortcuts.UseVisualStyleBackColor = true;
            this.btnShortcuts.Click += new System.EventHandler(this.btnShortcuts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пътека с филми";
            // 
            // lblVideoDirectory
            // 
            this.lblVideoDirectory.AutoSize = true;
            this.lblVideoDirectory.Location = new System.Drawing.Point(15, 32);
            this.lblVideoDirectory.Name = "lblVideoDirectory";
            this.lblVideoDirectory.Size = new System.Drawing.Size(38, 17);
            this.lblVideoDirectory.TabIndex = 10;
            this.lblVideoDirectory.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 285);
            this.Controls.Add(this.lblVideoDirectory);
            this.Controls.Add(this.btnDownloadSubtitles);
            this.Controls.Add(this.btnGetMoviePath);
            this.Controls.Add(this.chkIsSeries);
            this.Controls.Add(this.chkUseRealName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnShortcuts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMoviesPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Видеотека";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMoviePath;
        private System.Windows.Forms.TextBox txtBoxMoviesPath;
        private System.Windows.Forms.Button btnDownloadSubtitles;
        private System.Windows.Forms.ToolStripMenuItem настрийкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem директорияФилмиToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chkIsSeries;
        private System.Windows.Forms.CheckBox chkUseRealName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShortcuts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVideoDirectory;
    }
}

