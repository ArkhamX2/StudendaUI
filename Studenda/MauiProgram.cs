﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace Studenda;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiCommunityToolkit()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
