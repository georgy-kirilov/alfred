using Microsoft.AspNetCore.Mvc.Testing;

namespace Alfred.WebApi.Tests;

public sealed class ApiTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GreetShouldReturnHelloWithCorrectName()
    {
        var response = await _client.GetAsync("/greet?name=John", TestContext.Current.CancellationToken);

        response.EnsureSuccessStatusCode();

        var body = await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken);

        Assert.Equal("Hello, John!", body);
    }
}
