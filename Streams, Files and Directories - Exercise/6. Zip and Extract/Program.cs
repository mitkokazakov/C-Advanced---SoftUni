using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\TU Gabrovo\Copy", @"D:\TU Gabrovo\Zip\MyArchive.zip");
            ZipFile.ExtractToDirectory(@"D:\TU Gabrovo\Zip\MyArchive.zip", @"D:\TU Gabrovo\Extract");
        }
    }
}
