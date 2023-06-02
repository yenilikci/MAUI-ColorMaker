﻿namespace ColorMaker;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Slider_ValueChanged(object sender, EventArgs e)
	{
		var red = sldRed.Value;
		var green = sldGreen.Value;
		var blue = sldBlue.Value;

		Color color = Color.FromRgb(red, green, blue);
		SetColor(color);
	}

    private void SetColor(Color color)
    {
		btnRandom.BackgroundColor = color;  
		Container.BackgroundColor = color;
		lblHex.Text = color.ToHex();
    }
}

