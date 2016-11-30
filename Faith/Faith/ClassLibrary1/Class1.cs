using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HopeLogic
    {
        static int Main (string[] arg)
        {

            return 0;
        }


    }

    public class FileOrganization
    {
        private string[] header = {"document", "digital", "desktop", "apps", "other"};

        


        private void FileArray()
        {
            int i = 0;
            string[] headerPath = new string[5];
            foreach (var head in header)
            {
                string[] temp = Directory.GetFiles(@"C: \Users\turtle\Desktop\", head, SearchOption.TopDirectoryOnly);
                Console.WriteLine(temp[i]);
                i++;
            }
        }

        static int Main()
        {
            FileOrganization file = new FileOrganization();
            Console.WriteLine(file.header[1]);
            return 0;
        }
    }

    

}
