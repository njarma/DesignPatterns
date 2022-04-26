using FactoryMethod.Buttons;

namespace FactoryMethod.Factory
{
    public abstract class Dialog
    {
        public void renderWindow()
        {
            IButton button = createButton();
            button.render();
        }

        /**
        * Subclasses will override this method in order to create specific button
        * objects.
        */
        public abstract IButton createButton();
    }
}