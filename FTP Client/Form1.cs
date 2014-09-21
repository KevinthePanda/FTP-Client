using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTPManager;

namespace FTP_Client
{
    
    public partial class Form1 : Form
    {
        FTPManagerClass client;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            client = new FTPManagerClass(txtUsername.Text.Trim(), txtPassword.Text.Trim(), "ftp://" + txtHost.Text.Trim());
   
            btndelete.Enabled = true;
            btnDownload.Enabled = true;
            btnewDir.Enabled = true;
            btnFileSize.Enabled = true;
            btnLstFiles.Enabled = true;
            btnUpload.Enabled = true;
            btnRename.Enabled = true;
        }

        private void btnLstFiles_Click(object sender, EventArgs e)
        {
            string[] files = client.lsDirectory("");
            foreach (string filename in files)
            {
                dataGridView1.Rows.Add(filename);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFilDlg = new OpenFileDialog();
            if (opFilDlg.ShowDialog() == DialogResult.OK)
            {
                client.UploadFile(opFilDlg.FileName);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();
            if (txtUpload.Text.Trim().Length > 0)
            {
                if (fldDlg.ShowDialog() == DialogResult.OK)
                {
                    client.DownloadFile(txtUpload.Text.Trim(),fldDlg.SelectedPath);
                }
            }
            else
            {
                MessageBox.Show("Please enter the File name to download");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            if (txtUpload.Text.Trim().Length > 0)
            {
                client.Delete(txtUpload.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please enter the File name to delete");
            }
        }

        private void btnFileSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + client.getFileSize(txtUpload.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Rename(txtCurrentFilename.Text.Trim(), txtNewFilename.Text.Trim());
        }

        private void btnewDir_Click(object sender, EventArgs e)
        {
            client.CreateDir(txtNewDir.Text);
        }
        
    }
}
