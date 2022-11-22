namespace MauiSliderNotWorkingCorrectlyOnMac;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	void OnUpdateSliderMinimum(System.Object sender, System.EventArgs e)
	{
		slider.Minimum -= 5;
	}
	void OnUpdateSliderValue(System.Object sender, System.EventArgs e)
	{
		slider.Value += 5;
	}
	void OnUpdateSliderMaximum(System.Object sender, System.EventArgs e)
	{
		slider.Maximum += 5;
	}
}

