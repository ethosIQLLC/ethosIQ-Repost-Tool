using ethosIQ_FTP;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ethosIQ_Repost_Tool
{
    public class HistoricalOutput
    {
        public string Name;
        public string Directory;
        public FTP Ftp;
        public FTPType FTPType;

        public HistoricalOutput(string Name, string Type, string Directory, FTP Ftp)
        {
            this.Name = Name;
            this.FTPType = (FTPType)Enum.Parse(typeof(FTPType), Type, true);
            this.Directory = Directory;
            this.Ftp = Ftp;
        }

        public void SendFile(string FilePath, string FileName)
        {
            if (Ftp != null)
            {
                Ftp.UploadFile(FilePath, Directory, FileName);
            }
        }
    }
}
