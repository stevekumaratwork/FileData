using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public interface IFileRepository
    {
        bool IsvalidForVersion(string firstArgument, string secondArgument);
        bool IsvalidForFileSize(string firstArgument, string secondArgument);
    }
}
