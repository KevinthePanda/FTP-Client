using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace FTPManager
{
    public class FTPManagerClass
    {
        //remote user password
        private static string password;
        //remote user
        private static string username;
        //hostname or ip address of the FTP server
        private static string host;

        //initialization of our ftp Request, Response, and Stream 
        private FtpWebRequest ftpRequest = null; //creates the ftp client
        private FtpWebResponse ftpResponse = null; //gets request from a server
        private Stream ftpStream = null; //the means of transfering

        //constructor
        public FTPManagerClass(string user, string pass, string hostname)
        {
            username = user;
            password = pass;
            host = hostname;
        }

        //download method
        public void DownloadFile(string remoteFile, string localFile)
        {
            try
            {
                //Creating the FTP Request, its settings, and login handling//
                //sends request
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri(host + "/" + remoteFile));
                //log in to the server with the credentials
                ftpRequest.Credentials = new NetworkCredential(username, password);
                //specifies request type
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile; 

                //toggables//
                ftpRequest.UseBinary = true; //specifies file types for transfers is binary
                ftpRequest.UsePassive = true; //specifies that the connection is from the client to the server
                ftpRequest.KeepAlive = true; //specifies we want the connetion to continue after the request is complete
                

                //Creates the communication for the server to the client and creates a io stream in which the file can be written//
                //establishes server to client communication
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                //gets the servers response stream
                ftpStream = ftpResponse.GetResponseStream(); 
                //creates a File Stream to write the downloaded file
                FileStream localFileStream = new FileStream(localFile + "\\" + remoteFile, FileMode.Create); 
                //buffer for downloading the data in bytes it is an array of bytes of the size of the remote file.
                byte[] byteBuffer = new byte[Convert.ToInt32(getFileSize(remoteFile))]; 
                //length of the bytes read in the stream
                int bytesRead = ftpStream.Read(byteBuffer, 0, Convert.ToInt32(getFileSize(remoteFile))); //bytes are read from the stream and the number of bytes read are stored into this variable
                //the stream reads in a maximum of bytes equal to the size of the remote file. these bytes are then stored into the bytebuffer array starting at the 0 position within the array.
                //the position of the stream is then advanced by the number of bytes in which are read

                try
                {
                    while (bytesRead > 0) //loops until no bytes are being read
                    {
                        //writes the byte data into the local file
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        //reads more byte data
                        bytesRead = ftpStream.Read(byteBuffer, 0, Convert.ToInt32(getFileSize(remoteFile)));
                    }
                }
                catch (Exception ex) //error message
                {
                    MessageBox.Show(ex.Message);
                }

                //closes processes and resources
                ftpResponse.Close();
                ftpStream.Close();
                localFileStream.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //uploadFile method
        public void UploadFile(string localFile)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(localFile);
                //for the most part the same as download
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri(host + "/" + fileInfo.Name));
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile; //method is now upload
                ftpStream = ftpRequest.GetRequestStream();
                FileStream localFileStream = fileInfo.OpenRead(); //stream to upload
                byte[] bytebuffer = new byte[localFileStream.Length]; //the length of the array is the size of the local file
                int bytesSend = localFileStream.Read(bytebuffer, 0, (int)localFileStream.Length); //reads in byte data from the local file with the max count of the length of the file

                try
                {
                    while (bytesSend != 0) //uploads until the transfer is complete. when there are no more bytes left to send
                    {
                        //writes to the ftpStream for the upload
                        ftpStream.Write(bytebuffer, 0, bytesSend);
                        //reads more bytes to the buffer
                        bytesSend = localFileStream.Read(bytebuffer, 0, (int)localFileStream.Length);

                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                localFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //renaming method
        public void Rename(string oldname, string newname)
        {
            try
            {   
                //requires a request and a response
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + oldname);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                ftpRequest.RenameTo = newname; //sets to a new name
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                //end processes
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //gets files in a directory and outputs them as a string
        public string[] lsDirectory(string dir)
        {
            string[] filesInDir = new string[10];
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + dir);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UsePassive = true;
                ftpRequest.UseBinary = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader sr = new StreamReader(ftpStream); //since this is only for input
                string dirRaw = null; //used to store the raw response
                try
                {
                    while (sr.Peek() != -1) //until no more avaliable characters
                    {
                        dirRaw += sr.ReadLine() + "|"; //adds on lines to our raw directory variable with "|" seperating lines for easier parsing
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //close resources
                ftpResponse.Close();
                sr.Close();
                ftpStream.Close();
                ftpRequest = null;

                try
                {
                    filesInDir = dirRaw.Split("|".ToCharArray()); //gets rid of |
                    return filesInDir;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return filesInDir;
        }

        public void Delete(string filename)
        {
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + filename);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateDir(string name)
        {
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + name);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public long getFileSize(string filename)
        {
            long size = 0;
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + filename);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                ftpRequest.UseBinary = true;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                size = ftpResponse.ContentLength;

                ftpResponse.Close();
                ftpRequest = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return size;
        }


    }
}
