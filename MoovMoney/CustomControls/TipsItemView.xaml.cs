namespace MoovMoney.CustomControls;

public partial class TipsItemView : ContentView
{
	public TipsItemView()
	{
		InitializeComponent();
	}

    public string TipsDescription
    {
        get => (string)GetValue(TipsDescriptionProperty);
        set => SetValue(TipsDescriptionProperty, value);
    }

    public static readonly BindableProperty TipsDescriptionProperty =
        BindableProperty.Create(
            declaringType: typeof(TipsItemView),
            propertyName: nameof(TipsDescription),
            returnType: typeof(string),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay);

    public string TipsName
    {
        get => (string)GetValue(TipsNameProperty);
        set => SetValue(TipsNameProperty, value);
    }

    public static readonly BindableProperty TipsNameProperty =
        BindableProperty.Create(
            declaringType: typeof(TipsItemView),
            propertyName: nameof(TipsName),
            returnType: typeof(string),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay);


    public string TipsIcon
    {
        get => (string)GetValue(TipsIconProperty);
        set => SetValue(TipsIconProperty, value);
    }

    public static readonly BindableProperty TipsIconProperty =
        BindableProperty.Create(
            declaringType: typeof(TipsItemView),
            propertyName: nameof(TipsIcon),
            returnType: typeof(string),
            defaultValue: "share.png",
            defaultBindingMode: BindingMode.OneWay);
}