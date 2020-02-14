using System;

namespace CsDesignPatterns_Command
{
    internal class TurnOffCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The Light turns off \n");
        }
    }
}