namespace MoovMoney.Models;

public class ServiceItem
{
    public string ServiceIcon { get; set; }
    public Color ServiceBackgroundColor { get; set; }
    public string ServiceName { get; set; }
    public float ServiceIconScale { get; set; }
    public ServiceDomain ServiceDomain { get; set; } = ServiceDomain.OtherServices;
}

public enum ServiceDomain
{
    Electricity,
    Water,
    TV,
    Bank,
    Supermarket,
    OnlineShop,
    TotalCard,
    CampusFrance,
    OtherServices
}
