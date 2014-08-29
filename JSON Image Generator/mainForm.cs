using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSON_Image_Generator
{
    public partial class mainForm : Form
    {
        private JsonTextReader jsonReader;
        private JsonTextWriter jsonWriter;

        private FolderBrowserDialog folderBrowser;

        private OpenFileDialog openJsonFileDialog;
        private SaveFileDialog saveJsonFileDialog;

        public mainForm()
        {
            InitializeComponent();

            folderBrowser = new FolderBrowserDialog();

            openJsonFileDialog = new OpenFileDialog();
            openJsonFileDialog.Filter = "JSON Files (.json)|*.json";
            openJsonFileDialog.FileOk += openJsonFileDialog_FileOk;

            saveJsonFileDialog = new SaveFileDialog();
            saveJsonFileDialog.Filter = "JSON Files (.json)|*.json";
            saveJsonFileDialog.FileOk += saveJsonFileDialog_FileOk;
        }

        void openJsonFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = sender as OpenFileDialog;
            jsonReader = new JsonTextReader(new StringReader(File.ReadAllText(dialog.FileName)));
        }

        void saveJsonFileDialog_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openJsonFileDialog.ShowDialog();
        }
    }
}
