using MediatR;

namespace DockerTest3.Handlers
{
    public class HelloWorldRequest : IRequest<string>
    {

    }
    public class HelloWorldRequestHandler : IRequestHandler<HelloWorldRequest,string>
    {
        public HelloWorldRequestHandler()
        {
        }

        public async Task<string> Handle(HelloWorldRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(100); // Simulate work time ¯\_(ツ)_/¯
            
            return "Hello World!";
        }
    }
}
