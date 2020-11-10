namespace CQRSTest
{
    public interface ICommandHandler
    {
        void Handle<T>(T command);
    }
}