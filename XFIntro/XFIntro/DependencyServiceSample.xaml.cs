using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFIntro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependencyServiceSample : ContentPage
    {
        public DependencyServiceSample ()
        {
            InitializeComponent ();
        }

        public void onReadClicked(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak(readText.Text);
        }
    }
}