using myprogressapp1.Interfaces;
using System.Reflection;

namespace myprogressapp1.Factory
{
    public class ProgramFactory
    {
        private readonly Dictionary<string, Type> _programs;

        public ProgramFactory()
        {
            _programs = typeof(IProgramInterface).Assembly
                .GetTypes()
                .Where(type => type.IsClass && !type.IsAbstract && typeof(IProgramInterface).IsAssignableFrom(type))
                .ToDictionary(type => type.Name, type => type, StringComparer.OrdinalIgnoreCase);
        }

        public IProgramInterface ExecuteProgram(string programName)
        {
            if (string.IsNullOrWhiteSpace(programName))
                throw new ArgumentException("Program name cannot be empty.", nameof(programName));

            if (!_programs.TryGetValue(programName, out Type? programType))
            {
                throw new ArgumentException($"Invalid program name '{programName}'. Available programs: {string.Join(", ", _programs.Keys.OrderBy(x => x))}");
            }

            var instance = Activator.CreateInstance(programType) as IProgramInterface;
            if (instance == null)
            {
                throw new InvalidOperationException($"Could not create instance for program '{programName}'.");
            }

            return instance;
        }
    }
}
