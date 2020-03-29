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
            this.txtBoxMoviesPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShortcuts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.chkUseRealName = new System.Windows.Forms.CheckBox();
            this.chkIsSeries = new System.Windows.Forms.CheckBox();
            this.btnGetMoviePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxMoviesPath
            // 
            this.txtBoxMoviesPath.Location = new System.Drawing.Point(99, 20);
            this.txtBoxMoviesPath.Name = "txtBoxMoviesPath";
            this.txtBoxMoviesPath.Size = new System.Drawing.Size(383, 22);
            this.txtBoxMoviesPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // btnShortcuts
            // 
            this.btnShortcuts.Location = new System.Drawing.Point(492, 106);
            this.btnShortcuts.Name = "btnShortcuts";
            this.btnShortcuts.Size = new System.Drawing.Size(112, 39);
            this.btnShortcuts.TabIndex = 2;
            this.btnShortcuts.Text = "Shortcuts";
            this.btnShortcuts.UseVisualStyleBackColor = true;
            this.btnShortcuts.Click += new System.EventHandler(this.btnShortcuts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Define name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(99, 57);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(383, 22);
            this.txtBoxName.TabIndex = 3;
            // 
            // chkUseRealName
            // 
            this.chkUseRealName.AutoSize = true;
            this.chkUseRealName.Location = new System.Drawing.Point(15, 97);
            this.chkUseRealName.Name = "chkUseRealName";
            this.chkUseRealName.Size = new System.Drawing.Size(100, 21);
            this.chkUseRealName.TabIndex = 5;
            this.chkUseRealName.Text = "Real Name";
            this.chkUseRealName.UseVisualStyleBackColor = true;
            // 
            // chkIsSeries
            // 
            this.chkIsSeries.AutoSize = true;
            this.chkIsSeries.Location = new System.Drawing.Point(15, 124);
            this.chkIsSeries.Name = "chkIsSeries";
            this.chkIsSeries.Size = new System.Drawing.Size(109, 21);
            this.chkIsSeries.TabIndex = 6;
            this.chkIsSeries.Text = "Movie series";
            this.chkIsSeries.UseVisualStyleBackColor = true;
            // 
            // btnGetMoviePath
            // 
            this.btnGetMoviePath.Location = new System.Drawing.Point(492, 20);
            this.btnGetMoviePath.Name = "btnGetMoviePath";
            this.btnGetMoviePath.Size = new System.Drawing.Size(112, 30);
            this.btnGetMoviePath.TabIndex = 7;
            this.btnGetMoviePath.Text = "Folder";
            this.btnGetMoviePath.UseVisualStyleBackColor = true;
            this.btnGetMoviePath.Click += new System.EventHandler(this.btnGetMoviePath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 159);
            this.Controls.Add(this.btnGetMoviePath);
            this.Controls.Add(this.chkIsSeries);
            this.Controls.Add(this.chkUseRealName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnShortcuts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMoviesPath);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VideoShortcuts Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMoviesPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShortcuts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.CheckBox chkUseRealName;
        private System.Windows.Forms.CheckBox chkIsSeries;
        private System.Windows.Forms.Button btnGetMoviePath;
    }
}

