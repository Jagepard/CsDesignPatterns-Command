using System;

namespace CsDesignPatterns_Command
{
    public interface IDevice
    {
        void SetCommand(string v, ICommand command);
        void Execute(string v);
    }
}