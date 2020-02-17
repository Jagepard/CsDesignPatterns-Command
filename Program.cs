/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDevice device = new Lamp();

            try
            {
                device.SetCommand("on", new TurnOnCommand());
                device.SetCommand("off", new TurnOffCommand());
                device.SetCommand("toggle", new ToggleCommand());
                device.Execute("on");
                device.Execute("off");
                device.Execute("toggle");
                device.Execute("toggle");
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: {0} \n", e.Message);
            }
        }
    }
}
