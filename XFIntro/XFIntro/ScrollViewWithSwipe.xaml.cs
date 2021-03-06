﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFIntro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScrollViewWithSwipe : ContentPage
    {
        public ScrollViewWithSwipe ()
        {
            InitializeComponent ();
            BindingContext = new ScrollViewWithSwipeViewModel();
            MessagingCenter.Subscribe<ScrollViewWithSwipeViewModel>(this, "MyAlert", cb);

        }

        private async void cb(ScrollViewWithSwipeViewModel obj)
        {
            await DisplayAlert("SwipedRight", "SwipedRight", "ok");
        }
    }
}