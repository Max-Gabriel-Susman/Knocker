﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Knocker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MapTabbedPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
