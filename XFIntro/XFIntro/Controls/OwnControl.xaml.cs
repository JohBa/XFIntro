using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFIntro.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OwnControl : Grid
	{
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(FooText), typeof(string), typeof(OwnControl));

        public string FooText
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public OwnControl()
		{
			InitializeComponent();
		}
	}
}