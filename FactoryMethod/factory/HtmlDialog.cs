using FactoryMethod.Buttons;

namespace FactoryMethod.Factory
{
    public class HtmlDialog: Dialog
    {
        public override IButton createButton()
        {
            return new HtmlButton();
        }
    }
}