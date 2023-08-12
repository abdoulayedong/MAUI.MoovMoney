using Microsoft.Extensions.Logging;
using FreshMvvm.Maui.Extensions;
using MoovMoney.Pages;
using MoovMoney.PageModels;

namespace MoovMoney
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fa-solid-900.otf", "FA-S");
                    fonts.AddFont("fa-regular-400.otf", "FA-R");
                });

#if DEBUG
            //builder.Logging.AddDebug();
#endif
            builder.Services.Add(ServiceDescriptor.Transient<HomeTabPage, HomeTabPage>());
            builder.Services.Add(ServiceDescriptor.Transient<OurPartnersTabPage, OurPartnersTabPage>());
            builder.Services.Add(ServiceDescriptor.Transient<MyAccountTabPage, MyAccountTabPage>());

            builder.Services.Add(ServiceDescriptor.Transient<HomeTabPageModel, HomeTabPageModel>());
            builder.Services.Add(ServiceDescriptor.Transient<OurPartnersTabPageModel, OurPartnersTabPageModel>());
            builder.Services.Add(ServiceDescriptor.Transient<MyAccountTabPageModel, MyAccountTabPageModel>());

            MauiApp mauiApp = builder.Build();

            mauiApp.UseFreshMvvm();

            return mauiApp;

        }
    }
}