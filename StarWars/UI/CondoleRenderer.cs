using System;

namespace StarWars.UI
{
    public class CondoleRenderer
    {
        public void WriteLine(string message, params object[] param)
        {
            Console.WriteLine(message, param);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
