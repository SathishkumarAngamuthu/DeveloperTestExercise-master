using System;
using System.Diagnostics;
using System.IO;

namespace ThirdPartyTools
{
    public class FileDetails
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string Version(string filePath)
        {
            string version = null;
            try
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(filePath);
                    version = versionInfo.FileVersion;
                }
                else
                {

                    Console.Write(Constant.FilePathReuired);
                    Console.ReadLine();
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return version;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public int Size(string filePath)
        {
            int size = 0;
            try
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    // Get file size
                    FileInfo fi = new FileInfo(filePath);
                    size = Convert.ToInt32(fi.Length);
                }
                else
                {

                    Console.Write(Constant.FilePathReuired);
                    Console.ReadLine();
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
            return size;
        }
    }
}
