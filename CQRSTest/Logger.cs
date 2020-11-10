namespace CQRSTest
{
    public class Logger : ICommandHandler
    {
        private readonly ICommandHandler _next;

        private readonly IWriter _writer;
        
        public Logger(ICommandHandler next, IWriter writer)
        {
            _next = next;
            _writer = writer;
        }
        
        public void Handle<T>(T command)
        {
            _writer.Write("Log before...");
            _next.Handle(command);
            _writer.Write("Log After...");
        }
    }
}