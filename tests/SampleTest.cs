
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace tests;

public class SampleTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public SampleTest(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Get_Root_ReturnsSuccessAndCorrectContentType()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("/");

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        Assert.Equal("text/html; charset=utf-8", 
            response.Content.Headers.ContentType.ToString());
    }

    [Fact]
    public async Task Get_Root_ReturnsHelloWorld()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetStringAsync("/");

        // Assert
        Assert.Equal("Hello World!", response);
    }
}
