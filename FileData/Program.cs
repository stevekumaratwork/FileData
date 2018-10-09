using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class Program
    {
        static void Main(string[] args)
        {
            FileRepositoryExternalService frs = new FileData.FileRepositoryExternalService();

            FileInformationService service = new FileInformationService(frs);

            if (args.Length > 1)
            {
                Console.WriteLine("Version Number : " + service.GetVersionNumber(args[0], args[1]));

                Console.WriteLine("File Size : " + service.GetFileSize(args[0], args[1]));
            }
            else
            {
                Console.WriteLine("Please type first and second arguments");
            }
            
            Console.ReadLine();
            
        }
    }
}
