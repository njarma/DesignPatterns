using System;

namespace FactoryMethod.Buttons
{
    public class HtmlButton: IButton
    {
        public void render()
        {
            Console.WriteLine("<button>HTML Button</button>");
        }
        public void onClick()
        {
            Console.WriteLine("Click done!");
        }
    }   
}