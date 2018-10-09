using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileRepositoryExternalService : IFileRepository
    {
        public bool IsvalidForVersion(string firstArgument, string secondArgument)
        {
            switch (firstArgument)
            {
                case "-v":
                    return true;
                    break;
                case "--v":
                    return true;
                    break;
                case "/v":
                    return true;
                    break;
                case "--version":
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }

        public bool IsvalidForFileSize(string firstArgument, string secondArgument)
        {
            switch (secondArgument)
            {
                case "-s":
                    return true;
                    break;
                case "--s":
                    return true;
                    break;
                case "/s":
                    return true;
                    break;
                case "--size":
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
