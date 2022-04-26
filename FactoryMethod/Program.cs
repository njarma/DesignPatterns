using FactoryMethod.Factory;

namespace FactoryMethod
{
    class Program
    {
        private static Dialog dialog;
        static void Configure()
        {
            dialog = new HtmlDialog();
        }

        static void Run()
        {
            dialog.renderWindow();
        }
        static void Main(string[] args)
        {
            Configure();
            Run();
        }

    }
}
