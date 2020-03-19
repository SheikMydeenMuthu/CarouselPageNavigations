using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselPageNavigations
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselPageNavigations.View.GalleryPage();
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
