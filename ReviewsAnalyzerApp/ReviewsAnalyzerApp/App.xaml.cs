﻿using Xamarin.Forms;

namespace ReviewsAnalyzerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ReviewsView());
        }
    }
}
