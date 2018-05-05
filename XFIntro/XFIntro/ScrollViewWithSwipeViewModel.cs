using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFIntro
{
    public class ScrollViewWithSwipeViewModel
    {

        public ScrollViewWithSwipeViewModel()
        {

        }

        public Command SwipeRightCommand
        {
            get
            {
                return new Command(() => MessagingCenter.Send(this, "MyAlert"));
            }
        }
    }
}
