using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using File_Size_Calculator.Properties;

namespace File_Size_Calculator {
    public partial class Form_Main : Form {
        public Form_Main() {
            InitializeComponent();
        }

        /// <summary>
        /// Automatically resizes the first column when the ListView is resized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_Resize(object sender, EventArgs e) {
            listView_Files.Columns[0].Width = listView_Files.Width - listView_Files.Columns[1].Width - listView_Files.Columns[2].Width - 30;
        }

        /// <summary>
        /// Opens the folder browser when the Browse button is clicked.
        /// Updates the directory path TextBox if the OK button is clicked and the selected path exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Dir_Browse_Click(object sender, EventArgs e) {
            if(Directory.Exists(textBox_Dir_Path.Text))
                folderBrowserDialog_Dir.SelectedPath = textBox_Dir_Path.Text;
            if((folderBrowserDialog_Dir.ShowDialog() == DialogResult.OK) && (Directory.Exists(folderBrowserDialog_Dir.SelectedPath)))
                textBox_Dir_Path.Text = folderBrowserDialog_Dir.SelectedPath;
        }

        /// <summary>
        /// Formats the extension filter in the style *.ext and saves it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Dir_Extension_Leave(object sender, EventArgs e) {
            FormatExtension();
        }

        /// <summary>
        /// Formats the extension filter in the style *.ext and saves it.
        /// </summary>
        private void FormatExtension() {
            string ext = textBox_Dir_Extension.Text;
            string newExt = "*";
            int start = ext.LastIndexOf('.');

            if(!(string.IsNullOrEmpty(ext) || ext == "*")) {
                if(start < 0)
                    newExt = string.Format("*.{0}", ext);
                else
                    newExt = string.Format("*{0}", ext.Substring(start));
            }

            textBox_Dir_Extension.Text = newExt;
            Settings.Default.LastExtension = newExt;
            Settings.Default.Save();
        }

        /// <summary>
        /// Loads the settings when the application loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e) {
            if(!Settings.Default.FirstRun) {
                Location = Settings.Default.LastLocation;
            }
            Size = Settings.Default.LastSize;
            if(Directory.Exists(Settings.Default.LastDirectory)) {
                textBox_Dir_Path.Text = Settings.Default.LastDirectory;
            }
            textBox_Dir_Path.Select(textBox_Dir_Path.Text.Length, 0);
            textBox_Dir_Extension.Text = Settings.Default.LastExtension;
            textBox_Files_Percentage.Text = Settings.Default.LastPercentage;

            Settings.Default.FirstRun = false;
            Settings.Default.Save();
        }

        /// <summary>
        /// Saves the directory when the directory text is changed if it exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Dir_Path_TextChanged(object sender, EventArgs e) {
            if(Directory.Exists(textBox_Dir_Path.Text)) {
                Settings.Default.LastDirectory = textBox_Dir_Path.Text;
                Settings.Default.Save();

                LoadFileList();
            }
        }

        /// <summary>
        /// Loads the list of files.
        /// </summary>
        private void LoadFileList() {
            if(!textBox_Files_Percentage.Text.Contains('%'))
                textBox_Files_Percentage.Text = string.Format("{0}%", textBox_Files_Percentage.Text);
            listView_Files.Items.Clear();
            long fileSize = 0;
            double percentage = double.Parse(textBox_Files_Percentage.Text.Substring(0, textBox_Files_Percentage.Text.Length - 1)) / 100;

            foreach(string file in Directory.GetFiles(textBox_Dir_Path.Text, textBox_Dir_Extension.Text,
                                                            checkBox_Dir_Subdirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)) {
                fileSize = new FileInfo(file).Length;
                listView_Files.Items.Add(new ListViewItem(new string[] { file, fileSize.ToString(), (Math.Ceiling(fileSize * percentage)).ToString() }));
            }
        }
        /// <summary>
        /// Saves the subdirectories checkbox state when it is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_Dir_Subdirectories_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.LastSubdirectories = checkBox_Dir_Subdirectories.Checked;
            Settings.Default.Save();

            LoadFileList();
        }

        /// <summary>
        /// Saves the location of the form.
        /// </summary>
        private void SaveLocation() {
            Settings.Default.LastLocation = Location;
            Settings.Default.Save();
        }

        /// <summary>
        /// Saves the size of the form.
        /// </summary>
        private void SaveSize() {
            Settings.Default.LastSize = Size;
            Settings.Default.Save();
        }

        // Formats and saves the extension filter when the form closes.
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e) {
            SaveLocation();
            SaveSize();
            FormatExtension();
        }

        private void textBox_Files_Percentage_KeyDown(object sender, KeyEventArgs e) {
# if DEBUG
            Console.WriteLine(string.Format("KeyCode: {0}", e.KeyCode));
            Console.WriteLine(string.Format("KeyData: {0}", e.KeyData));
            Console.WriteLine(string.Format("KeyValue: {0}", e.KeyValue));
            Console.WriteLine("");
# endif
            bool percentSignInBox = textBox_Files_Percentage.Text.LastIndexOf('%') > 0;
            bool decimalInBox = textBox_Files_Percentage.Text.LastIndexOf('.') > 0;
            bool inputAtEnd = textBox_Files_Percentage.SelectionStart == textBox_Files_Percentage.Text.Length;

            bool numberKey = (Keys.D0 <= e.KeyCode && e.KeyCode <= Keys.D9 && !e.Shift) || (Keys.NumPad0 <= e.KeyCode && e.KeyCode <= Keys.NumPad9);
            bool decimalKey = (e.KeyCode == Keys.OemPeriod) || (e.KeyCode == Keys.Decimal);
            bool percentKey = (e.Shift && e.KeyCode == Keys.D5);
            bool navigationKey = (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Home)
                              || (e.KeyCode == Keys.End) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right);
            bool cutCopy = (e.Control && e.KeyCode == Keys.X) || (e.Control && e.KeyCode == Keys.C);
            bool validPaste = false;
            if(e.Control && e.KeyCode == Keys.V) {
                int ssStart = Math.Min(0, textBox_Files_Percentage.SelectionStart);
                int ssLength = textBox_Files_Percentage.Text.Length - textBox_Files_Percentage.SelectionLength;
                validPaste = ValidPasteData(textBox_Files_Percentage.Text.Substring(ssStart, ssLength), inputAtEnd);
            }

            e.SuppressKeyPress = !(
                    (numberKey && !percentSignInBox)                                    // Allow number keys if there is no percent sign.
                || (numberKey && percentSignInBox && !inputAtEnd)                      // Allow number keys if there is a percent sign but the cursor isn't at the end.
                || (decimalKey && !decimalInBox && !percentSignInBox)                  // Allow one decimal point anywhere if there's no percent sign.
                || (decimalKey && !decimalInBox && percentSignInBox && !inputAtEnd)    // Allow one decimal point if it's before the percent sign.
                || (percentKey && !percentSignInBox && inputAtEnd)                     // Allow one percent sign at the end.
                || navigationKey                                                       // Allow all navigation keys.
                || cutCopy                                                             // Allow cut and copy operations.
                || (validPaste && percentSignInBox && !inputAtEnd)                     // Allow only valid paste operations.
                );
        }

        /// <summary>
        /// Validates the data stored in the clipboard.
        /// </summary>
        /// <param name="context">The text of the TextBox being pasted into.</param>
        /// <param name="inputAtEnd">The position of the cursor in the TextBox.</param>
        /// <returns>True if the paste is allowed, false otherwise.</returns>
        private bool ValidPasteData(string context, bool inputAtEnd) {
            string data = string.Empty;
            bool contextHasPc = context.Contains('%'), contextHasDec = context.Contains('.');

            try {
                data = (string)Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.Text);
            } catch {
                return false;
            }

            if(
                    (context.Contains('%') && inputAtEnd)
                || (context.Contains('%') && data.Contains('%'))
                || (context.Contains('.') && data.Contains('.'))
                || (Count('%', data) > 1)
                || (Count('.', data) > 1)
               )
                return false;

            foreach(char c in data) {
                if(!char.IsDigit(c) && c != '%' && c != '.')
                    return false;
            }

            return true;
        }

        private int Count(char c, string input) {
            int count = 0;
            for(int i = 0; i < input.Length; i++)
                if(input.Contains(c))
                    count++;

            return count;
        }

        /// <summary>
        /// Saves the text in the percentage box whenever it changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Files_Percentage_TextChanged(object sender, EventArgs e) {
            Settings.Default.LastPercentage = textBox_Files_Percentage.Text;
            Settings.Default.Save();
            LoadFileList();
        }

        private void textBox_Dir_Extension_TextChanged(object sender, EventArgs e) {
            FormatExtension();
            LoadFileList();
        }

        private void listView_Files_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right)
                contextMenu_Files.Show(listView_Files, e.Location);
        }

        private void menuItem_Copy_Click(object sender, EventArgs e) {
            try {
                Clipboard.SetDataObject(listView_Files.SelectedItems[0].SubItems[2].Text);
            } catch {
            }
        }
    }
}
