using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            return new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" },

            };
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}