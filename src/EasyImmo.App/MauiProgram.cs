using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace EasyImmo.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit(options =>
                {
                    options.SetShouldEnableSnackbarOnWindows(true);
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("SegoeUIVF.ttf", "SegoeUI");
                    fonts.AddFont("Segoe Fluent Icons.ttf", "FluentIcons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<TitlebarWindow>();
            return builder.Build();
        }
    }
}
