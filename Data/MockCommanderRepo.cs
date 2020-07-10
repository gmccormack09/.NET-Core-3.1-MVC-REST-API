using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo : ICommanderRepo {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands(){
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Boil An Egg", Line="Boil Water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Boil Kettle", Line="Turn On Kettle", Platform="Kettle"},
                new Command{Id=2, HowTo="Cut Bread", Line="Get Knife", Platform="Knife and Plate"}
            };
            return commands;
        }
        public Command GetCommandByID(int id){
            return new Command{Id=0, HowTo="Boil An Egg", Line="Boil Water", Platform="Kettle and Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}