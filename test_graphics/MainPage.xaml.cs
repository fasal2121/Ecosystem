using System.Diagnostics;

namespace test_graphics;

public partial class MainPage : ContentPage
{
    IDispatcherTimer timer;
    Simulation simulation;

    public MainPage()
    {
        InitializeComponent();

        simulation = Resources["simulation"] as Simulation;

        timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromMilliseconds(500);
        timer.Tick += this.OnTimeEvent;
        timer.Start();
    }

    private void OnTimeEvent(object source, EventArgs e)
    {
        try
        {
            simulation.Update();
            graphics.Invalidate();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
        }
    }
}




