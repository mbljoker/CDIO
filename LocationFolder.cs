using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TestEmgCV
{
    public class LocationFolder
    {
        string PathLocationFolder;
        string KeyLock;
        bool Status=false;
        string PathLocationFolderLock;
        bool FileFolder;
       
        string NameF;

        public string getNameF()
        {
            return NameF;
        }

        public void setNameF(string path)
        {
            NameF = path;
        }

        public string getPathLocationFolder()
        {
            return PathLocationFolder;
        }

        public void setPathLocationFolder(string path)
        {
            PathLocationFolder = path;
        }

        public string getPathLocationFolderLock()
        {
            return PathLocationFolderLock;
        }

        public void setPathLocationFolderLock(string path)
        {
            PathLocationFolderLock= path;
        }

        public string getKeyLock()
        {
            return KeyLock;
        }

        public void setKeyLock(string path)
        {
            KeyLock = path;
        }

        

        public bool getStatus()
        {
            return Status;
        }

        public void setStatus(bool path)
        {
            Status = path;
        }

        public bool getFileFolder()
        {
            return FileFolder;
        }

        public void setFileFolder(bool path)
        {
            FileFolder = path;
        }

    }
}
