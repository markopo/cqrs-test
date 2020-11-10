using System;

namespace CQRSTest
{
    public class ConsoleWriter: IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           var consoleWriter = new ConsoleWriter();

           var repo = new Logger(new Security(new UserRepository(consoleWriter), consoleWriter), consoleWriter);
           
           repo.Handle<string>("Message Sent...");
           
        }
    }
}