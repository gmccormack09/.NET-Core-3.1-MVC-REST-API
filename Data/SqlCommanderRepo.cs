using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd ==null){
                throw new System.ArgumentNullException(nameof(cmd));
            }
            _context.commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd ==null){
                throw new System.ArgumentNullException(nameof(cmd));
            }
            _context.commands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.commands.ToList();
        }

        public Command GetCommandByID(int id)
        {
            return _context.commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
        }
    }
}