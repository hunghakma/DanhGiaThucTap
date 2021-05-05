﻿using DanhGiaThucTap.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DanhGiaThucTap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LenhDieuKienPage());
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
