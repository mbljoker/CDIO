using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmgCV
{
    public class LocationFolder
    {
        string PathLocationFolder;
        string KeyLock;
        bool Status=false;
        string PathLocationFolderLock;
        bool FileFolder;

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


        ///Tải dữ liệu File lên
        public List<LocationFolder> loadFlieLock()
        {
            List<LocationFolder> arrLocation = new List<LocationFolder>();
            if (File.Exists(Application.StartupPath + "/SaveFolder/LocationFolder.txt"))
            {
                
                try
                {
                    StreamReader SR = new StreamReader(Application.StartupPath + "/SaveFolder/LocationFolder.txt", Encoding.Unicode);
                    string line;
                    while ((line = SR.ReadLine()) != null)
                    {
                        ///Chuẩn : Tên File|Thuộc Tính File | Địa chỉ Lock File|KeyLock| Trạng Thái
                        string[] arrStr = line.Split('|');
                         
                        LocationFolder tam = new LocationFolder();    
                        tam.setPathLocationFolder(arrStr[0]);
                        tam.setFileFolder(arrStr[1] == "1" ? true : false);
                        tam.setPathLocationFolderLock(arrStr[2]);
                        tam.setKeyLock(arrStr[3]);
                        tam.setStatus(arrStr[4] == "1" ? true : false);
                        arrLocation.Add(tam);            
                    }
                   // MessageBox.Show(""+arrLocation.Count);
                    SR.Close();
                    return arrLocation;
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
           // else return false;
            return arrLocation;
        }


    }
}
