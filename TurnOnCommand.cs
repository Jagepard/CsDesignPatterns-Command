using System;

namespace CsDesignPatterns_Command
{
    internal class TurnOnCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The Light turns on \n");
        }
    }
}