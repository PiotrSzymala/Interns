using FluentAssertions;
using Interns.Controllers;

namespace Interns.Tests;

public class FileDownloaderUnitTests
{
    [Theory]
    [InlineData("https://fortedigital.github.io/Back-End-Internship-Task/interns.json")]
    [InlineData("https://fortedigital.github.io/Back-End-Internship-Task/interns.csv")]
    [InlineData("https://fortedigital.github.io/Back-End-Internship-Task/interns.zip")]
    public void FileDownloader_ForValidInputArgument(string url)
    {
        // act
        var result = FileDownloader.DownloadFile(url);

        // assert 
        result.Should().NotBeEmpty("because with valid input argument downloading should end successfully");

    }

    [Theory]
    [InlineData("https://fortedigital.github.io/Back-End-Internship-Task/interns.js")]
    [InlineData("https://fortedigital.github.io/Back-End-Internship-Task/interns.cv")]
    [InlineData("https://fortedigital.github.io/Back-End-Internship-Task/interns.zi")]
    public void FileDownloader_ForInvalidInputArgument(string url)
    {
        // act
        var result = FileDownloader.DownloadFile(url);

        // assert
        result.Should().BeEmpty();
    }
}