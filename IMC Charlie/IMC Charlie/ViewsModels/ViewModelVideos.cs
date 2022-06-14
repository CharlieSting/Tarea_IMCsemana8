using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace IMC_Charlie.ViewsModels
{
    public class ViewModelVideos : INotifyPropertyChanged
    {
        public ViewModelVideos()
        {

            CambiarVideo1 = new Command(() => {

                VideoActual = videoIMC;

            });

            CambiarVideo2 = new Command(() => {

                VideoActual = videoIMC2;

            });


        }


        private string videoIMC = "https://youtu.be/Wmp8OJl2q38";
        private string videoIMC2 = "https://youtu.be/m5GQzP9zgtg";

        string videoActual = "https://youtu.be/6bWUl6tRZiQ";


        public String VideoActual
        {
            get => videoActual;
            set
            {
                videoActual = value;
                var args = new PropertyChangedEventArgs(nameof(VideoActual));
                PropertyChanged?.Invoke(this, args);
            }
        }


        public Command CambiarVideo1 { get; }
        public Command CambiarVideo2 { get; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}