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
    public class FileInformationServiceTests
    {
        // Requirements for the exercise (using TDD)
        // The programe accepts two input arguments
        // It should return file version number if the first argument is one of the following (–v, --v, /v, --version) and the second argument is a file name.
        // It should return the file size if the second argument is one of the following (–s, --s, /s, --size).
        // There are no requirements for this exercise for checking the file existance or accessing the file.

        [Fact]
        public void GivenTheFirstArgumentIsValidTheVersionNumberShouldBeReturned()
        {
            Mock<IFileRepository> fileRepo = new Mock<IFileRepository>();
            fileRepo.Setup(x => x.IsvalidForVersion(It.IsIn("-v", "--v", "/v", "--version"), "c:/ test.txt")).Returns(true);
            FileInformationService service = new FileInformationService(fileRepo.Object);

            string versionNumber = service.GetVersionNumber("-v", "c:/test.txt");

            Assert.NotEqual("FileDetails.Version", versionNumber);
        }

        [Fact]
        public void GivenTheSecondArgumentIsValidTheFileSizeShouldBeReturned()
        {
            Mock<IFileRepository> fileRepo = new Mock<IFileRepository>();
            fileRepo.Setup(x => x.IsvalidForFileSize("c:/ test.txt", It.IsIn("-s", "--s", "/s", "--size"))).Returns(true);
            FileInformationService service = new FileInformationService(fileRepo.Object);

            string fileSize = service.GetFileSize("c:/test.txt", "-s");

            Assert.NotEqual("FileDetails.Size", fileSize);
        }

        [Fact]
        public void InvalidFirstArgumentShouldFailTheReturnOfTheFileVersion()
        {
            Mock<IFileRepository> fileRepo = new Mock<IFileRepository>();
            fileRepo.Setup(x => x.IsvalidForVersion(It.IsIn("-v", "--v", "/v", "--version"), "c:/ test.txt")).Returns(true);
            FileInformationService service = new FileInformationService(fileRepo.Object);

            string versionNumber = service.GetVersionNumber("-a", "c:/test.txt");

            Assert.NotEqual("FileDetails.Version", versionNumber);
        }

        [Fact]
        public void InvalidSecondArgumentShouldFailTheReturnOfTheFileSize()
        {
            Mock<IFileRepository> fileRepo = new Mock<IFileRepository>();
            fileRepo.Setup(x => x.IsvalidForFileSize("c:/ test.txt", It.IsIn("-s", "--s", "/s", "--size"))).Returns(true);
            FileInformationService service = new FileInformationService(fileRepo.Object);

            string fileSize = service.GetFileSize("c:/test.txt", "-b");

            Assert.NotEqual("FileDetails.Size", fileSize);
        }
    }
}
