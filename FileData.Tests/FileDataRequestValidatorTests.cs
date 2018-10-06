using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using FileData;



namespace FileData.Tests
{
    public class FileDataRequestValidatorTests
    {
        [Fact]
        public void InvalidInputArgumentWouldNotReturnVersionNumber()
        {
            Mock<IInputArgumentValidator> mockValidator = new Mock<IInputArgumentValidator>();
                       
            mockValidator.Setup(x => x.IsValidArgument(It.IsIn("-v", "--v", "/v", "--version"))).Returns(true);
            var sut = new FileDataRequestValidator(mockValidator.Object);

            var versionRequest = new InputArgument
            {
                FirstArgument = "w",
                SecondArgument = "c:/test.txt"
            };
                        
            OutputStatus outcome = sut.ValidateVersionRequest(versionRequest);

            Assert.Equal(OutputStatus.InvalidArgument, outcome);


        }

    }
}
