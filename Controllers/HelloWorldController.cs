using Microsoft.AspNetCore.Mvc;
using HelloWorld.Controllers.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HelloWorld.Controllers;

[ApiController]
[Route("/greeting/v1")]
[Produces("application/json")]
public class HelloWorldController : ControllerBase
{
    [HttpPost("hello-world", Name = nameof(HelloWorldController))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult PostHelloWorld([FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Disallow)] List<HelloWorldDto> helloWorlds)
    {
        if (helloWorlds == null || helloWorlds.Count == 0) {
            return Problem("Oh no");
        }
        return Content("List was not empty");
    }

}