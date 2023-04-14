namespace App.Controls.Buttons;

public partial class NextBackArrow : ContentView
{
	public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(NextBackArrow), string.Empty);
	public string Icon
	{
		get => (string)GetValue(IconProperty);
		set => SetValue(IconProperty, value);
	}

	public static readonly BindableProperty AccessibilityTextProperty = BindableProperty.Create(nameof(AccessibilityText), typeof(string), typeof(NextBackArrow), string.Empty);
	public string AccessibilityText
	{
		get => (string)GetValue(AccessibilityTextProperty);
		set => SetValue(AccessibilityTextProperty, value);
	}
	public event EventHandler? Clicked;

	public NextBackArrow()
	{
		InitializeComponent();
	}

	void StateButton_Clicked(object sender, EventArgs e)
	{
		Clicked?.Invoke(this, EventArgs.Empty);
	}
}