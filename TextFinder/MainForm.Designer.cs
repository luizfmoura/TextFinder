namespace TextFinder
{
    partial class MainForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSearchSubdirectories = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.btnCleanUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(12, 25);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(927, 20);
            this.txtFolderPath.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(945, 25);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(119, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "Choose a folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pattern:";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(73, 12);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(100, 20);
            this.txtPattern.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContains);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkSearchSubdirectories);
            this.groupBox1.Controls.Add(this.txtPattern);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(73, 42);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(360, 20);
            this.txtContains.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contains:";
            // 
            // chkSearchSubdirectories
            // 
            this.chkSearchSubdirectories.AutoSize = true;
            this.chkSearchSubdirectories.Location = new System.Drawing.Point(191, 15);
            this.chkSearchSubdirectories.Name = "chkSearchSubdirectories";
            this.chkSearchSubdirectories.Size = new System.Drawing.Size(128, 17);
            this.chkSearchSubdirectories.TabIndex = 8;
            this.chkSearchSubdirectories.Text = "Search subdirectories";
            this.chkSearchSubdirectories.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Folder Path:";
            // 
            // listViewFiles
            // 
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.Location = new System.Drawing.Point(12, 135);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(1052, 309);
            this.listViewFiles.TabIndex = 9;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            // 
            // btnCleanUp
            // 
            this.btnCleanUp.Location = new System.Drawing.Point(945, 57);
            this.btnCleanUp.Name = "btnCleanUp";
            this.btnCleanUp.Size = new System.Drawing.Size(119, 23);
            this.btnCleanUp.TabIndex = 10;
            this.btnCleanUp.Text = "Clean";
            this.btnCleanUp.UseVisualStyleBackColor = true;
            this.btnCleanUp.Click += new System.EventHandler(this.btnCleanUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 456);
            this.Controls.Add(this.btnCleanUp);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFolderPath);
            this.Name = "MainForm";
            this.Text = "TextFinder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.CheckBox chkSearchSubdirectories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.Button btnCleanUp;
    }
}

