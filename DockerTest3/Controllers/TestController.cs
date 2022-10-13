using DockerTest3.Handlers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerTest3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<TestController> logger;

        public TestController(IMediator mediator, ILogger<TestController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<string>> HelloWorld()
        {
            return Ok(await mediator.Send(new HelloWorldRequest()));
        }
    }
}
