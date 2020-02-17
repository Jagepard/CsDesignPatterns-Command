/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace CsDesignPatterns_Command
{
    internal class ToggleCommand : ICommand
    {
        private int toggle = 0b1;
        public ICommand Command { get; set; }

        public void Execute()
        {
            Command = (toggle % 0b10) == 0b1 ? new TurnOnCommand() : (ICommand) new TurnOffCommand();
            toggle++;
            Command.Execute();
        }
    }
}
