using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        private static readonly FileDetails _fileDetails = new FileDetails();
        public static void Main(string[] args)
        {
            //args[0] = functionality to perform
            //args[1] = filename/filepath            
            switch (Convert.ToString(args[0]))
            {
                case "-v":
                    Console.WriteLine(Constant.Fileversion +_fileDetails.Version(args[1]));
                    break;
                case "--v":
                    Console.WriteLine(Constant.Fileversion + _fileDetails.Version(args[1]));
                    break;
                case "v":
                    Console.WriteLine(Constant.Fileversion + _fileDetails.Version(args[1]));
                    break;
                case "--version":
                    Console.WriteLine(Constant.Fileversion + _fileDetails.Version(args[1]));
                    break;

                case "-s":
                    Console.WriteLine(Constant.FileSize + _fileDetails.Size(args[1]));
                    break;
                case "--s":
                    Console.WriteLine(Constant.FileSize + _fileDetails.Size(args[1]));
                    break;
                case "s":
                    Console.WriteLine(Constant.FileSize + _fileDetails.Size(args[1]));
                    break;
                case "--size":
                    Console.WriteLine(Constant.FileSize + _fileDetails.Size(args[1]));
                    break;

                default:
                    break;
            }
            Console.WriteLine(Constant.EnterKey);
            Console.ReadKey();
        }

    }
}
