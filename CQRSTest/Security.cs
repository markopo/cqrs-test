namespace CQRSTest
{
    public class Security : ICommandHandler
    {
        private readonly ICommandHandler _next;
        private readonly IWriter _writer;

        public Security(ICommandHandler next, IWriter writer)
        {
            _next = next;
            _writer = writer;
        }
        public void Handle<T>(T command)
        {
            _writer.Write("Security before...");
            _next.Handle(command);
            _writer.Write("Security after...");
        }
    }
}