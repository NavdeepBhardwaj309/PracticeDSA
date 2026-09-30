using myprogressapp1.Factory;
using myprogressapp1.Interfaces;

namespace myprogressapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string algorithmName = args.Length > 0 ? args[0] : "BucketSort";

            var factory = new ProgramFactory();
            IProgramInterface program = factory.ExecuteProgram(algorithmName);
            program.ExecuteProgram();
        }
    }
}
