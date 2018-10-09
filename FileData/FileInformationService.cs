using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileInformationService
    {
        IFileRepository repo;
        public FileInformationService(IFileRepository fileRepo)
        {
            repo = fileRepo;
        }

        public string GetVersionNumber(string firstArgument, string secondArgument)
        {
            if (repo.IsvalidForVersion(firstArgument, secondArgument))
            {
                return "FileDetails.Version";
            }
            return "Invalid Arguments";
        }

        public string GetFileSize(string firstArgument, string secondArgument)
        {
            if (repo.IsvalidForFileSize(firstArgument, secondArgument))
            {
                return "FileDetails.Size";
            }
            return "Invalid Arguments";
        }
    }
}
