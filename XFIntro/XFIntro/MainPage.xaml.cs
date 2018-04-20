using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFIntro
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void SharedClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleShared());
        }

        void ControlClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserControl());
        }

        void RendererClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomRenderer());
        }

    }
}
