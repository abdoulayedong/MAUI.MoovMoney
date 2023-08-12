namespace MoovMoney.CustomControls;

public partial class ServicesItemView : ContentView
{
	public ServicesItemView()
	{
		InitializeComponent();
	}

    public string ServiceName
    {
        get => (string)GetValue(ServiceNameProperty);
        set => SetValue(ServiceNameProperty, value);
    }

    public static readonly BindableProperty ServiceNameProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(ServiceName),
            returnType: typeof(string),
            defaultValue: "Top up credit",
            defaultBindingMode: BindingMode.OneWay);

    public string ServiceIcon
    {
        get => (string)GetValue(ServiceIconProperty);
        set => SetValue(ServiceIconProperty, value);
    }

    public static readonly BindableProperty ServiceIconProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(ServiceIcon),
            returnType: typeof(string),
            defaultValue: "phone.png",
            defaultBindingMode: BindingMode.OneWay);

    public float ServiceIconRotation
    {
        get => (float)GetValue(ServiceIconRotationProperty);
        set => SetValue(ServiceIconRotationProperty, value);
    }

    public static readonly BindableProperty ServiceIconRotationProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(ServiceIconRotation),
            returnType: typeof(float),
            defaultValue: 0.0f,
            defaultBindingMode: BindingMode.OneWay);
}