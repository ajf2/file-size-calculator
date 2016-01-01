namespace File_Size_Calculator {
    partial class Form_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button_Dir_Browse = new System.Windows.Forms.Button();
            this.textBox_Dir_Path = new System.Windows.Forms.TextBox();
            this.checkBox_Dir_Subdirectories = new System.Windows.Forms.CheckBox();
            this.label_Dir_Extension = new System.Windows.Forms.Label();
            this.textBox_Dir_Extension = new System.Windows.Forms.TextBox();
            this.groupBox_Dir = new System.Windows.Forms.GroupBox();
            this.groupBox_Files = new System.Windows.Forms.GroupBox();
            this.textBox_Files_Percentage = new System.Windows.Forms.TextBox();
            this.label_Files_Percentage = new System.Windows.Forms.Label();
            this.listView_Files = new System.Windows.Forms.ListView();
            this.columnHeader_File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CalcSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog_Dir = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenu_Files = new System.Windows.Forms.ContextMenu();
            this.menuItem_Copy = new System.Windows.Forms.MenuItem();
            this.groupBox_Dir.SuspendLayout();
            this.groupBox_Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Dir_Browse
            // 
            this.button_Dir_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Dir_Browse.AutoSize = true;
            this.button_Dir_Browse.Location = new System.Drawing.Point(384, 20);
            this.button_Dir_Browse.Name = "button_Dir_Browse";
            this.button_Dir_Browse.Size = new System.Drawing.Size(73, 23);
            this.button_Dir_Browse.TabIndex = 12;
            this.button_Dir_Browse.Text = "&Browse...";
            this.button_Dir_Browse.UseVisualStyleBackColor = true;
            this.button_Dir_Browse.Click += new System.EventHandler(this.button_Dir_Browse_Click);
            // 
            // textBox_Dir_Path
            // 
            this.textBox_Dir_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Dir_Path.Location = new System.Drawing.Point(6, 22);
            this.textBox_Dir_Path.Name = "textBox_Dir_Path";
            this.textBox_Dir_Path.Size = new System.Drawing.Size(372, 20);
            this.textBox_Dir_Path.TabIndex = 11;
            this.textBox_Dir_Path.TextChanged += new System.EventHandler(this.textBox_Dir_Path_TextChanged);
            // 
            // checkBox_Dir_Subdirectories
            // 
            this.checkBox_Dir_Subdirectories.AutoSize = true;
            this.checkBox_Dir_Subdirectories.Checked = true;
            this.checkBox_Dir_Subdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Dir_Subdirectories.Location = new System.Drawing.Point(6, 51);
            this.checkBox_Dir_Subdirectories.Name = "checkBox_Dir_Subdirectories";
            this.checkBox_Dir_Subdirectories.Size = new System.Drawing.Size(129, 17);
            this.checkBox_Dir_Subdirectories.TabIndex = 13;
            this.checkBox_Dir_Subdirectories.Text = "Include &subdirectories";
            this.checkBox_Dir_Subdirectories.UseVisualStyleBackColor = true;
            this.checkBox_Dir_Subdirectories.CheckedChanged += new System.EventHandler(this.checkBox_Dir_Subdirectories_CheckedChanged);
            // 
            // label_Dir_Extension
            // 
            this.label_Dir_Extension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Dir_Extension.AutoSize = true;
            this.label_Dir_Extension.Location = new System.Drawing.Point(203, 51);
            this.label_Dir_Extension.Name = "label_Dir_Extension";
            this.label_Dir_Extension.Size = new System.Drawing.Size(91, 13);
            this.label_Dir_Extension.TabIndex = 4;
            this.label_Dir_Extension.Text = "Filter by extension";
            // 
            // textBox_Dir_Extension
            // 
            this.textBox_Dir_Extension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Dir_Extension.Location = new System.Drawing.Point(300, 48);
            this.textBox_Dir_Extension.Name = "textBox_Dir_Extension";
            this.textBox_Dir_Extension.Size = new System.Drawing.Size(78, 20);
            this.textBox_Dir_Extension.TabIndex = 14;
            this.textBox_Dir_Extension.Text = "*";
            this.textBox_Dir_Extension.TextChanged += new System.EventHandler(this.textBox_Dir_Extension_TextChanged);
            this.textBox_Dir_Extension.Leave += new System.EventHandler(this.textBox_Dir_Extension_Leave);
            // 
            // groupBox_Dir
            // 
            this.groupBox_Dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Dir.Controls.Add(this.button_Dir_Browse);
            this.groupBox_Dir.Controls.Add(this.textBox_Dir_Path);
            this.groupBox_Dir.Controls.Add(this.textBox_Dir_Extension);
            this.groupBox_Dir.Controls.Add(this.label_Dir_Extension);
            this.groupBox_Dir.Controls.Add(this.checkBox_Dir_Subdirectories);
            this.groupBox_Dir.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Dir.Name = "groupBox_Dir";
            this.groupBox_Dir.Size = new System.Drawing.Size(463, 83);
            this.groupBox_Dir.TabIndex = 10;
            this.groupBox_Dir.TabStop = false;
            this.groupBox_Dir.Text = "Select a directory";
            // 
            // groupBox_Files
            // 
            this.groupBox_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Files.Controls.Add(this.textBox_Files_Percentage);
            this.groupBox_Files.Controls.Add(this.label_Files_Percentage);
            this.groupBox_Files.Controls.Add(this.listView_Files);
            this.groupBox_Files.Location = new System.Drawing.Point(12, 101);
            this.groupBox_Files.Name = "groupBox_Files";
            this.groupBox_Files.Size = new System.Drawing.Size(463, 194);
            this.groupBox_Files.TabIndex = 20;
            this.groupBox_Files.TabStop = false;
            this.groupBox_Files.Text = "Files";
            // 
            // textBox_Files_Percentage
            // 
            this.textBox_Files_Percentage.Location = new System.Drawing.Point(173, 13);
            this.textBox_Files_Percentage.MaxLength = 8;
            this.textBox_Files_Percentage.Name = "textBox_Files_Percentage";
            this.textBox_Files_Percentage.Size = new System.Drawing.Size(59, 20);
            this.textBox_Files_Percentage.TabIndex = 21;
            this.textBox_Files_Percentage.Text = "100%";
            this.textBox_Files_Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Files_Percentage.TextChanged += new System.EventHandler(this.textBox_Files_Percentage_TextChanged);
            this.textBox_Files_Percentage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Files_Percentage_KeyDown);
            // 
            // label_Files_Percentage
            // 
            this.label_Files_Percentage.AutoSize = true;
            this.label_Files_Percentage.Location = new System.Drawing.Point(3, 16);
            this.label_Files_Percentage.Name = "label_Files_Percentage";
            this.label_Files_Percentage.Size = new System.Drawing.Size(164, 13);
            this.label_Files_Percentage.TabIndex = 8;
            this.label_Files_Percentage.Text = "Percentage to use in calculations";
            // 
            // listView_Files
            // 
            this.listView_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_File,
            this.columnHeader_Size,
            this.columnHeader_CalcSize});
            this.listView_Files.FullRowSelect = true;
            this.listView_Files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Files.Location = new System.Drawing.Point(3, 39);
            this.listView_Files.Name = "listView_Files";
            this.listView_Files.Size = new System.Drawing.Size(457, 152);
            this.listView_Files.TabIndex = 22;
            this.listView_Files.UseCompatibleStateImageBehavior = false;
            this.listView_Files.View = System.Windows.Forms.View.Details;
            this.listView_Files.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Files_MouseClick);
            this.listView_Files.Resize += new System.EventHandler(this.listView_Files_Resize);
            // 
            // columnHeader_File
            // 
            this.columnHeader_File.Text = "File";
            this.columnHeader_File.Width = 214;
            // 
            // columnHeader_Size
            // 
            this.columnHeader_Size.Text = "Original Size (bytes)";
            this.columnHeader_Size.Width = 117;
            // 
            // columnHeader_CalcSize
            // 
            this.columnHeader_CalcSize.Text = "Calculated Size (bytes)";
            this.columnHeader_CalcSize.Width = 121;
            // 
            // folderBrowserDialog_Dir
            // 
            this.folderBrowserDialog_Dir.Description = "Select the folder containing the files you would like to load.";
            this.folderBrowserDialog_Dir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog_Dir.ShowNewFolderButton = false;
            // 
            // contextMenu_Files
            // 
            this.contextMenu_Files.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Copy});
            // 
            // menuItem_Copy
            // 
            this.menuItem_Copy.Index = 0;
            this.menuItem_Copy.Text = "Copy Calculated Size";
            this.menuItem_Copy.Click += new System.EventHandler(this.menuItem_Copy_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 307);
            this.Controls.Add(this.groupBox_Files);
            this.Controls.Add(this.groupBox_Dir);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 345);
            this.Name = "Form_Main";
            this.Text = "File Size Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_Dir.ResumeLayout(false);
            this.groupBox_Dir.PerformLayout();
            this.groupBox_Files.ResumeLayout(false);
            this.groupBox_Files.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Dir_Browse;
        private System.Windows.Forms.TextBox textBox_Dir_Path;
        private System.Windows.Forms.CheckBox checkBox_Dir_Subdirectories;
        private System.Windows.Forms.Label label_Dir_Extension;
        private System.Windows.Forms.TextBox textBox_Dir_Extension;
        private System.Windows.Forms.GroupBox groupBox_Dir;
        private System.Windows.Forms.GroupBox groupBox_Files;
        private System.Windows.Forms.ListView listView_Files;
        private System.Windows.Forms.ColumnHeader columnHeader_File;
        private System.Windows.Forms.ColumnHeader columnHeader_Size;
        private System.Windows.Forms.TextBox textBox_Files_Percentage;
        private System.Windows.Forms.Label label_Files_Percentage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Dir;
        private System.Windows.Forms.ContextMenu contextMenu_Files;
        private System.Windows.Forms.MenuItem menuItem_Copy;
        private System.Windows.Forms.ColumnHeader columnHeader_CalcSize;
    }
}

