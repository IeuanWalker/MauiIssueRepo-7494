using IeuanWalker.Maui.StateButton;
using IeuanWalker.Maui.Switch;
using Microsoft.Extensions.Logging;
#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif
using Microsoft.Maui.Platform;

namespace App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		MauiAppBuilder builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseStateButton()
			.UseSwitch();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (h, v) => {
#if ANDROID
			// Remove underline
			h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
			// Set cursor color
			if(h.PlatformView.TextCursorDrawable is not null)
			{
				h.PlatformView.TextCursorDrawable?.SetTint(v.TextColor.ToAndroid());
			}
#endif
		});

#if DEBUG
			builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}