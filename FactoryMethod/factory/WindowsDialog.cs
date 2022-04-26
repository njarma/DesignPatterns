using FactoryMethod.Buttons;

namespace FactoryMethod.Factory
{
    public class WindowsDialog: Dialog
    {
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }
}