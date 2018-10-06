using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileDataRequestValidator
    {
        private readonly IInputArgumentValidator _validator;

       
        public FileDataRequestValidator(IInputArgumentValidator validator)
        {
            _validator = validator;
        }

        public OutputStatus ValidateVersionRequest(InputArgument argument)
        {
            if (argument.FirstArgument == "-v")
            {
                return OutputStatus.ValidArgument;
            }

            if (argument.FirstArgument == "--v")
            {
                return OutputStatus.ValidArgument;
            }

            if (argument.FirstArgument == "/v")
            {
                return OutputStatus.ValidArgument;
            }

            if (argument.FirstArgument == "--version")
            {
                return OutputStatus.ValidArgument;
            }

            var isvalidArgument = _validator.IsValidArgument(argument.FirstArgument);


            return OutputStatus.InvalidArgument;
        }
    }
}
