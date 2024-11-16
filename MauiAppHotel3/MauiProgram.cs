using Microsoft.Extensions.Logging;

namespace MauiAppHotel3
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
                    fonts.AddFont("PTSans-Bold.ttf", "PTSansBold");
                    fonts.AddFont("PTSans-Regular.ttf", "PTSansRegular");
                    fonts.AddFont("PTSans-Italic.ttf", "PTSansItalic");
                   
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
