using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFiles
{
    public class Commands
    {
        
        public void RouteCommands (string? command)
        {

            if (!validCommand(command)) 
                return;

            CommandObject commands = LineCommand(command);

            if (commands.Action == "list")
            {
                ListCommand listCommand = new ListCommand();

                listCommand.ListFiles();
            } 

            if (commands.Action == "up")
            {
                UpCommand upCommand = new UpCommand();

                upCommand.UpFile(commands.Param);
            }

            if ( commands.Action == "down")
            {
                DownCommand downCommand = new DownCommand();

                downCommand.DownloadFile(int.Parse(commands.Param));
            }

        }

        private CommandObject LineCommand (string command)
        {
            List<string> commands = command.Split(" ").ToList();
            
            CommandObject commandsObject = new CommandObject();

            if (commands.Count() >= 1 && commands[0]?.Count() > 0)
                commandsObject.Action = commands[0];
            
            if (commands.Count() > 1 && commands[1]?.Length > 0)
                commandsObject.Param = commands[1];


            return commandsObject;
        }

        private class CommandObject 
        {
            public string? Action {  get; set; }
            public string? Param { get; set; }

        }; 


        private bool validCommand (string? command)
        {
            var valid = true;

            if (command == null || command.Count() == 0)
            {
                valid = false;
                Console.WriteLine("Comando inválido!");
            }

            return valid;
        }


    }
}
