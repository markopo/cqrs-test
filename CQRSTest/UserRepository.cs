namespace CQRSTest
{
    public class UserRepository : ICommandHandler
    {
        private readonly IWriter _writer;

        public UserRepository(IWriter writer)
        {
            _writer = writer;
        }

        public void Handle<T>(T command)
        {

            if (command is string)
            {
                _writer.Write("BINGO: " + command as string);
            }

            _writer.Write("Writing from user repo.");
        }
    }
}