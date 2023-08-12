using MoovMoney.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoovMoney.Converters
{
    public class EnumToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var domain = (ServiceDomain)value;
            switch (domain)
            {
                case ServiceDomain.Bank:
                    return "Bank";
                case ServiceDomain.CampusFrance:
                    return "Campus France";
                case ServiceDomain.Electricity:
                    return "Electricity";
                case ServiceDomain.Water:
                    return "Water";
                case ServiceDomain.TV:
                    return "TV";
                case ServiceDomain.TotalCard:
                    return "Total card";
                case ServiceDomain.OtherServices:
                    return "Other services";
                case ServiceDomain.Supermarket:
                    return "Supermarket";
                case ServiceDomain.OnlineShop:
                    return "Online shop";
            }
            return "Other services";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
