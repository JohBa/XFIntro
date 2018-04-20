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

    }
}
