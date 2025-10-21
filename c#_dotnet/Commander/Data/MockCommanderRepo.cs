using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Do an echo", Line = "Write echo", Platform = "unix" },
                new Command { Id = 1, HowTo = "Do an echo", Line = "Write echo", Platform = "unix" },
                new Command { Id = 2, HowTo = "Do an echo", Line = "Write echo", Platform = "unix" },
                new Command { Id = 3, HowTo = "Do an echo", Line = "Write echo", Platform = "unix" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Do an echo", Line = "Write echo", Platform = "unix" };
        }
    }
}