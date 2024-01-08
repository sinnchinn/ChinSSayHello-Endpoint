using Microsoft.AspNetCore.Mvc;

namespace ChinSSayHello_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloEndpoint : ControllerBase
{
    public string userInput = "";

    public SayHelloEndpoint()
    {
        
    }

    [HttpPost]
    [Route("AddName/{userName}")]
    public string AddName(string userName)
    {
        userInput = userName;
        return "Hello, " + userInput;
    }
    
}
