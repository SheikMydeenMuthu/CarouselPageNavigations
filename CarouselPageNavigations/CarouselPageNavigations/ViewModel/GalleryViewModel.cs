using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace CarouselPageNavigations.ViewModel
{
    
    public class GalleryViewModel:INotifyPropertyChanged
    {
        ObservableCollection<FileImageSource> _imageSources;
        public GalleryViewModel()
        {
            BindImage();
        }

        private void BindImage()
        {
            ImageSources = new ObservableCollection<FileImageSource>();
            ImageSources.Add("icon.png");
            ImageSources.Add("prism.png");
            ImageSources.Add("star.png");           

        }

        public ObservableCollection<FileImageSource> ImageSources
        {
            get { return _imageSources; }
            set
            {
                _imageSources = value;
                OnPropertyChanged();
            }
        }        

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }       

    }
}
