namespace MauiPlaygroundApp
{
    public partial class App : Application
    {
        public static int PINLength = 4;
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}