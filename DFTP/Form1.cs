using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DFTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            FuncRefreshRate.Enabled = true;
            UploadButton.Enabled = false;
            ConnectButton.Enabled = false;
            RefreshContent.Enabled = false;
            DownloadButton.Enabled = false;
            DeleteFromFtpButton.Enabled = false;
            BrowseLocalTextBox.Enabled = false;
            BrowseFTPTextBox.Enabled = false;
            RenameOnlineButton.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BrowseFTPButton_Click(object sender, EventArgs e)
        {
            try
            {
                ftpFileRead();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
            

        private void BrowseLocalButton_Click(object sender, EventArgs e)
        {
            BrowseLocalDialog.ShowDialog();
            BrowseLocalTextBox.Text = BrowseLocalDialog.SelectedPath.ToString();
            string[] Files = Directory.GetFiles(BrowseLocalDialog.SelectedPath);
            LocalFiles.Items.Clear();
            foreach (string file in Files) 
            {
                LocalFiles.Items.Add(file); 
            }
        }

        private void BrowseLocalDialog_HelpRequest(object sender, EventArgs e)
        {
         
        }

        public void Upload()
        {
            string filename = LocalFiles.SelectedItem.ToString();
            string ftpServerIP = HostBox.Text;
            string ftpUserName = UsernameBox.Text;
            string ftpPassword = PasswordBox.Text;

            FileInfo objFile = new FileInfo(filename);
            FtpWebRequest objFTPRequest;
            objFTPRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpServerIP + objFile.Name));
            objFTPRequest.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
            objFTPRequest.KeepAlive = false;
            objFTPRequest.UseBinary = true;
            objFTPRequest.ContentLength = objFile.Length;
            objFTPRequest.Method = WebRequestMethods.Ftp.UploadFile;
            int intBufferLength = 16 * 1024;
            byte[] objBuffer = new byte[intBufferLength];
            FileStream objFileStream = objFile.OpenRead();
            try
            {
                Stream objStream = objFTPRequest.GetRequestStream();

                int len = 0;

                while ((len = objFileStream.Read(objBuffer, 0, intBufferLength)) != 0)
                {
                    objStream.Write(objBuffer, 0, len);

                }
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(filename.ToString() + " Has been successfully uploaded to " + HostBox.Text.ToString() + "!", "DFTP");
                objStream.Close();
                objFileStream.Close();
                OnlineFiles.Items.Clear();
                ftpFileRead();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete()
        {
            try
            {

                string OpenFileName = OnlineFiles.SelectedItem.ToString();
                string FtpHost = HostBox.Text;
                string FtpUsername = UsernameBox.Text;
                string FtpPassword = PasswordBox.Text;
                FileInfo toUpload = new FileInfo(OpenFileName);
                FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create(FtpHost + toUpload.Name);
                requestFileDelete.Credentials = new NetworkCredential(FtpUsername, FtpPassword);
                requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();

                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(toUpload.Name + " has successfully been deleted from " + HostBox.Text + "!", "DFTP");

            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.ToString()); 
            }
            ftpFileRead();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                Upload();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LocalFiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Upload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       private void ftpFileRead()
       {
           OnlineFiles.Items.Clear();
           BrowseFTPTextBox.Text = HostBox.Text;
           FtpWebRequest Request = (FtpWebRequest)WebRequest.Create(HostBox.Text);
           Request.Method = WebRequestMethods.Ftp.ListDirectory;     
           Request.Credentials = new NetworkCredential(UsernameBox.Text, PasswordBox.Text);
           FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();
           Stream ResponseStream = Response.GetResponseStream();
           StreamReader Reader = new StreamReader(ResponseStream);

           OnlineFiles.Items.Add(Response.WelcomeMessage);
           while (!Reader.EndOfStream)
           {
           OnlineFiles.Items.Add(Reader.ReadLine().ToString());
           }
           Response.Close();
           ResponseStream.Close();
           Reader.Close();
}
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                BrowseFTPTextBox.Text = HostBox.Text;
                ftpFileRead();
            }

            catch(Exception ex) {

                MessageBox.Show(ex.ToString());

            }

        }

        private void UpdateOnlinePath_Tick(object sender, EventArgs e)
        {
            try{
                    ftpFileRead();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                UpdateListCheckBox.Checked = false;
            }
        }

        private void UpdateListCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateListCheckBox.Checked)
            {
                UpdateOnlinePath.Start();
            }
            else
            {
                UpdateOnlinePath.Stop();
            }
        }

        private void FuncRefreshRate_Tick(object sender, EventArgs e)
        {
            try
            {
                BrowseLocalTextBox.Text = BrowseLocalDialog.SelectedPath;

                if (HostBox.Text.Trim().Length == 0 && UsernameBox.Text.Trim().Length == 0 && PasswordBox.Text.Trim().Length == 0)
                {
                    UpdateListCheckBox.Enabled = false;
                    ConnectButton.Enabled = false;
                    RefreshContent.Enabled = false;

                }
                else
                {
                    UpdateListCheckBox.Enabled = true;
                    ConnectButton.Enabled = true;
                    RefreshContent.Enabled = true;
                }

                if (OnlineFiles.SelectedIndex == -1)
                {
                    RenameOnlineButton.Enabled = false;
                    DownloadButton.Enabled = false;
                    DeleteFromFtpButton.Enabled = false;
                }
                else
                {
                    RenameOnlineButton.Enabled = true;
                    DownloadButton.Enabled = true;
                    DeleteFromFtpButton.Enabled = true;
                }

                if (LocalFiles.SelectedIndex == -1)
                {
                    UploadButton.Enabled = false;
                }
                else
                {
                    UploadButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                FuncRefreshRate.Enabled = false;
            }
        }

        private void DeleteFromFtpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnlineFiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string SelectedItem = OnlineFiles.SelectedItem.ToString();
                BrowseFTPTextBox.Text = BrowseFTPTextBox.Text + "/" + SelectedItem;
                OnlineFiles.Items.Clear();
                FtpWebRequest Request = (FtpWebRequest)WebRequest.Create(BrowseFTPTextBox.Text);
                Request.Method = WebRequestMethods.Ftp.ListDirectory;
                Request.Credentials = new NetworkCredential(UsernameBox.Text, PasswordBox.Text);
                FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();
                Stream ResponseStream = Response.GetResponseStream();
                StreamReader Reader = new StreamReader(ResponseStream);

                OnlineFiles.Items.Add(Response.WelcomeMessage);
                while (!Reader.EndOfStream)
                {
                    OnlineFiles.Items.Add(Reader.ReadLine().ToString());
                }
                Response.Close();
                ResponseStream.Close();
                Reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RenameOnlineButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP");
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string localPath = SavePathFTPDownloadDialog.SelectedPath.ToString();
                string fileName = OnlineFiles.SelectedItem.ToString();
                string Username = UsernameBox.Text;
                string Password = PasswordBox.Text;
                string Host = BrowseFTPTextBox.Text;
                SavePathFTPDownloadDialog.ShowDialog();
                FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create(Host + fileName);
                requestFileDownload.Credentials = new NetworkCredential(Username, Password);
                requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();
                Stream responseStream = responseFileDownload.GetResponseStream();
                FileStream writeStream = new FileStream(localPath + fileName, FileMode.Create);
                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);
                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(fileName + " has been successfully been downloaded from " + Host + " server!");
                responseStream.Close();
                writeStream.Close();
                requestFileDownload = null;
                responseFileDownload = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
