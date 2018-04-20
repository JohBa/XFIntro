using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFIntro.Shared;

namespace XFIntro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleShared : ContentPage
    {
        private readonly Multiplier _multiplier;

        public SimpleShared()
        {
            InitializeComponent();
            _multiplier = new Multiplier();
        }

        void MultiplyClicked(object sender, EventArgs e)
        {
            try
            {
                resultLabel.Text = "" + _multiplier.Multiply(Convert.ToInt32(number1.Text), Convert.ToInt32(number2.Text));
            }
            catch(Exception)
            {
                resultLabel.Text = "Error!";
            }
        }

        void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}