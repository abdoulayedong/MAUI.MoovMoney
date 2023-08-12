using MoovMoney.Models;

namespace MoovMoney.CustomControls;

public partial class CircularItemView : ContentView
{
	public CircularItemView()
	{
		InitializeComponent();
	}

    public StackOrientation Orientation
    {
        get => (StackOrientation)GetValue(OrientationProperty);
        set => SetValue(OrientationProperty, value);
    }

    public static readonly BindableProperty OrientationProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(Orientation),
            returnType: typeof(StackOrientation),
            defaultValue: StackOrientation.Vertical,
            defaultBindingMode: BindingMode.OneWay);


    public ServiceDomain ServiceDomain
    {
        get => (ServiceDomain)GetValue(ServiceDomainProperty);
        set => SetValue(ServiceDomainProperty, value);
    }

    public static readonly BindableProperty ServiceDomainProperty =
        BindableProperty.Create(
            declaringType: typeof(CircularItemView),
            propertyName: nameof(ServiceDomain),
            returnType: typeof(ServiceDomain),
            defaultValue: ServiceDomain.OtherServices,
            defaultBindingMode: BindingMode.OneWay);


    public Color ServiceBackgroundColor
    {
        get => (Color)GetValue(ServiceBackgroundColorProperty);
        set => SetValue(ServiceBackgroundColorProperty, value);
    }

    public static readonly BindableProperty ServiceBackgroundColorProperty =
        BindableProperty.Create(
            declaringType: typeof(CircularItemView),
            propertyName: nameof(ServiceBackgroundColor),
            returnType: typeof(Color),
            defaultValue: Colors.White,
            defaultBindingMode: BindingMode.OneWay);

    public string ServiceName
    {
        get => (string)GetValue(ServiceNameProperty);
        set => SetValue(ServiceNameProperty, value);
    }

    public static readonly BindableProperty ServiceNameProperty =
        BindableProperty.Create(
            declaringType: typeof(CircularItemView),
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
            declaringType: typeof(CircularItemView),
            propertyName: nameof(ServiceIcon),
            returnType: typeof(string),
            defaultValue: "phone.png",
            defaultBindingMode: BindingMode.OneWay);

    public float ServiceIconHeight
    {
        get => (float)GetValue(ServiceIconHeightProperty);
        set => SetValue(ServiceIconHeightProperty, value);
    }

    public static readonly BindableProperty ServiceIconHeightProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(ServiceIconHeight),
            returnType: typeof(float),
            defaultValue: 70f,
            defaultBindingMode: BindingMode.OneWay);

    public float ServiceIconWidth
    {
        get => (float)GetValue(ServiceIconHeightProperty);
        set => SetValue(ServiceIconWidthProperty, value);
    }

    public static readonly BindableProperty ServiceIconWidthProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(ServiceIconWidth),
            returnType: typeof(float),
            defaultValue: 70f,
            defaultBindingMode: BindingMode.OneWay);

    public float ServiceIconScale
    {
        get => (float)GetValue(ServiceIconScaleProperty);
        set => SetValue(ServiceIconScaleProperty, value);
    }

    public static readonly BindableProperty ServiceIconScaleProperty =
        BindableProperty.Create(
            declaringType: typeof(ServicesItemView),
            propertyName: nameof(ServiceIconScale),
            returnType: typeof(float),
            defaultValue: 0.6f,
            defaultBindingMode: BindingMode.OneWay);

}