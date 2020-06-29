using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("copyMe.png", FileMode.Open))
            {
                using (FileStream stream2 = new FileStream("../../../newCopy.png", FileMode.Create))
                {

                    byte[] buffer = new byte[4096];

                    while (stream.CanRead)
                    {
                        var bytesRead = stream.Read(buffer, 0, buffer.Length);

                        if (bytesRead == 0)
                        {
                            break;
                        }

                        stream2.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
