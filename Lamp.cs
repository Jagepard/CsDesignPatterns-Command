using System;
using System.Collections.Generic;

namespace CsDesignPatterns_Command
{
    internal class Lamp : IDevice
    {
        public IDictionary<string, ICommand> Commands { get; } = new Dictionary<string, ICommand>();
        public void Execute(string commandName)
        {
            if (!Commands.ContainsKey(commandName))
            {
                throw new Exception("Command does not exist in the registry");
            }

            Commands[commandName].Execute();
        }

        public void SetCommand(string commandName, ICommand command)
        {
            if (Commands.ContainsKey(commandName))
            {
                throw new Exception("Command already exists");
            }

            Commands.Add(commandName, command);
        }
    }
}