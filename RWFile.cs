using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmgCV
{
    class RWFile
    {
        static public Hashtable IdLtFd = new Hashtable();
        /// <summary>
        /// Tải dữ liệu từ File lên
        /// </summary>
        /// <returns></returns>

        static public List<LocationFolder> loadFlieLock()
        {
            List<LocationFolder> arrLocation = new List<LocationFolder>();
            IdLtFd.Clear();
            if (File.Exists(Application.StartupPath + "/SaveFolder/LocationFolder.txt"))
            {

                try
                {
                    using (StreamReader SR = new StreamReader(Application.StartupPath + "/SaveFolder/LocationFolder.txt", Encoding.Unicode))
                    {
                        string line;
                        while ((line = SR.ReadLine()) != null)
                            if (line != "\n")
                            {
                                ///Chuẩn : Tên File|Thuộc Tính File | Địa chỉ Lock File|KeyLock| Trạng Thái
                                string[] arrStr = line.Split('|');
                                LocationFolder tam = new LocationFolder();
                                tam.setPathLocationFolder(arrStr[0]);
                                tam.setFileFolder(arrStr[1] == "1" ? true : false);
                                tam.setPathLocationFolderLock(arrStr[2]);
                                tam.setKeyLock(arrStr[3]);
                                tam.setStatus(arrStr[4] == "1" ? true : false);
                                tam.setNameF(arrStr[5]);
                                arrLocation.Add(tam);
                                IdLtFd.Add(arrStr[0], 1);
                            }
                
                        SR.Dispose();
                        SR.Close();

                    }
                    return arrLocation;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + " aaa");
                    return null;
                }
            }
            // else return false;
            return arrLocation;
        }

        /// <summary>
        /// Lưu Dữ liệu vào file SaveFolder
        /// </summary>
        /// <param name="file"></param>
        /// <param name="tam"></param>
        /// <param name="xoa"></param>
        /// <returns></returns>

        static public bool saveFile(string file, LocationFolder tam, bool xoa)
        {

            try
            {
                if (xoa == true)
                    if (File.Exists(file))
                    {
                        File.Delete(file);  
                        File.Create(file).Close() ;

                    }
                if (tam == null)
                {
                    return false;
                }


                using (StreamWriter SW = new StreamWriter(file, true, UnicodeEncoding.Unicode))
                {
                    ///Chuẩn : Tên File|Thuộc Tính File | Địa chỉ Lock File|KeyLock| Trạng Thái|FIle Name
                    string s = tam.getPathLocationFolder() + "|" + (tam.getFileFolder() ? "1" : "0") + "|" + tam.getPathLocationFolderLock() + "|"
                                      + tam.getKeyLock() + "|" + (tam.getStatus() ? "1" : "0") + "|" + tam.getNameF();
                    SW.Write(s + "\n");
                    SW.Dispose();
                    SW.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Lộc");
                return false;
            }

        }
    }
}
