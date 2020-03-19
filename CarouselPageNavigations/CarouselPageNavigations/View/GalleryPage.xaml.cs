using CarouselPageNavigations.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselPageNavigations.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        //ObservableCollection<FileImageSource> ImageSources;
        public GalleryPage()
        {
            InitializeComponent();
            BindingContext = new GalleryViewModel();
            //ImageSources = new ObservableCollection<FileImageSource>();
            //ImageSources.Add("icon.png");
            //ImageSources.Add("prism.png");
            //ImageSources.Add("star.png");
            //imgSlider.Images = ImageSources;
        }
    }
}