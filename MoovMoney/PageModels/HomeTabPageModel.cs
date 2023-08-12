using MoovMoney.Models;
using System.Collections.ObjectModel;

namespace MoovMoney.PageModels;

public class HomeTabPageModel : PageModelBase
{
    private ObservableCollection<ServiceItem> _favoritePartners;

    public ObservableCollection<ServiceItem> FavoritePartners
    {
        get => _favoritePartners;
        set => SetProperty(ref _favoritePartners, value);
    }

    public override void Init(object initData)
    {
        base.Init(initData);

        FavoritePartners = new ObservableCollection<ServiceItem>
            {
                new ()
                {
                    ServiceName = "Access to my bank",
                    ServiceIcon = "bank.png",
                    ServiceBackgroundColor = Colors.White,
                    ServiceIconScale = 0.6f,
                    ServiceDomain = ServiceDomain.Bank
                },
                new ()
                {
                    ServiceName = "Pay SEEG electricity",
                    ServiceIcon = "seeg.png",
                    ServiceBackgroundColor = Colors.White,
                    ServiceIconScale = 0.7f,
                    ServiceDomain = ServiceDomain.Electricity
                },
                new ()
                {
                    ServiceName = "Canal+",
                    ServiceIcon = "canalplus.png",
                    ServiceBackgroundColor = Colors.Black,
                    ServiceIconScale = 0.6f,
                    ServiceDomain = ServiceDomain.TV
                },
                new ()
                {
                    ServiceName = "Gimac",
                    ServiceIcon = "gimac.png",
                    ServiceBackgroundColor = Colors.White,
                    ServiceIconScale = 0.6f,
                    ServiceDomain = ServiceDomain.Bank
                },
                new ()
                {
                    ServiceName = "Satcon",
                    ServiceIcon = "satcon.png",
                    ServiceBackgroundColor = Colors.White,
                    ServiceIconScale = 0.6f,
                    ServiceDomain = ServiceDomain.TV
                },
                new ()
                {
                    ServiceName = "Pay SEEG water",
                    ServiceIcon = "seegb.png",
                    ServiceBackgroundColor = Color.FromHex("#1F467F"),
                    ServiceIconScale = 0.7f,
                    ServiceDomain = ServiceDomain.Water
                },
                new ()
                {
                    ServiceName = "Total",
                    ServiceIcon = "totaleng.png",
                    ServiceBackgroundColor = Colors.White,
                    ServiceIconScale = 0.6f,
                    ServiceDomain = ServiceDomain.TotalCard
                },
                new ()
                {
                    ServiceName = "Campus France",
                    ServiceIcon = "campusfr.png",
                    ServiceBackgroundColor = Colors.White,
                    ServiceIconScale = 0.5f,
                    ServiceDomain = ServiceDomain.CampusFrance
                },
            };
    }
}
