using Studenda.ViewModel;

namespace Studenda;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainViewModel mainViewModel = new MainViewModel();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
        window.Activated += Window_Activated;
        return window;
    }

    private async void Window_Activated(object sender, EventArgs e)
    {

#if ANDROID
    
#endif

#if WINDOWS
        const int DefaultWidth = 1368;
        const int DefaultHeight = 760;

        const int MinimumWidth = 440;
        const int MinimumHeight = 720;

        var window = sender as Window;

        // change window size.
        window.Width = DefaultWidth;
        window.Height = DefaultHeight;

        window.MinimumWidth = MinimumWidth;
        window.MinimumHeight = MinimumHeight;
        // give it some time to complete window resizing task.
        await window.Dispatcher.DispatchAsync(() => { });

        var disp = DeviceDisplay.Current.MainDisplayInfo;

        // move to screen center
        window.X = (disp.Width / disp.Density - window.Width) / 2;
        window.Y = (disp.Height / disp.Density - window.Height) / 2;
#endif
    }
}
