using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TextFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                var folderPath = txtFolderPath.Text;
                var pattern = txtPattern.Text;
                var searchOption = SearchOption.TopDirectoryOnly;
                var contains = txtContains.Text.Trim();

                if (chkSearchSubdirectories.Checked)
                {
                    searchOption = SearchOption.AllDirectories;
                }

                CleanPreviousSearch();
                EnableNewSearch(false);
                Search(folderPath, pattern, searchOption, contains);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                EnableNewSearch(true);
            }
        }

        private void Search(string folderPath, string pattern, SearchOption searchOption, string contains)
        {
            if (string.IsNullOrEmpty(pattern))
            {
                pattern = "*";
            }

            var files =
                from retrievedFile in Directory.EnumerateFiles(folderPath, pattern, searchOption)
                from line in File.ReadLines(retrievedFile)
                where line.Contains(contains)
                select new
                {
                    File = retrievedFile,
                    Line = line
                };

            foreach (var file in files)
            {
                listViewFiles.Items.Add(string.Format("File: {0} / Line: {1}", file.File, file.Line));
            }
        }

        private void EnableNewSearch(bool enable)
        {
            btnFolder.Enabled = enable;
            btnSearch.Enabled = enable;
        }

        private void CleanPreviousSearch()
        {
            listViewFiles.Items.Clear();
        }

        private void btnCleanUp_Click(object sender, EventArgs e)
        {
            txtFolderPath.Text = string.Empty;
            txtPattern.Text = string.Empty;
            chkSearchSubdirectories.Checked = false;
            txtContains.Text = string.Empty;
            CleanPreviousSearch();
        }
    }
}