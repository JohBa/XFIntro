using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XFIntro;
using XFIntro.UWP;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(UwpEntryRenderer))]
namespace XFIntro.UWP
{
    class UwpEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new SolidColorBrush(Colors.Cyan);
                Control.BackgroundFocusBrush = new SolidColorBrush(Colors.Cyan);
            }
        }
    }
}
