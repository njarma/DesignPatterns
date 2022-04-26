using System;

namespace FactoryMethod.Buttons
{
    public class WindowsButton: IButton
    {
        public void render()
        {
            Console.WriteLine("I am a windows button");
        }
        public void onClick()
        {
            Console.WriteLine("Click done!");
        }
    }   
}