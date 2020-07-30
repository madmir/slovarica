using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slovarica : ContentPage
    {
        public Slovarica()
        {
            InitializeComponent();

            var slike = new List<SlovaricaItem>
            {
                new SlovaricaItem
                {
                    Image = "slauto.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slbijeliluk.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slbik.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slbrod.jpeg"
                },
                new SlovaricaItem
                {
                    Image = "slcilim.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slcizma.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slcrv.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slcvijet.jpg"
                },
                new SlovaricaItem
                {
                    Image = "sldjak.jpeg"
                },
                new SlovaricaItem
                {
                    Image = "sldrvo.jpeg"
                },
                new SlovaricaItem
                {
                    Image = "sldzamija.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slekser.jpg"
                },
                new SlovaricaItem
                {
                    Image = "slflasa.jpg"
                },
            };

            slike.Shuffle();
            SlovaricaView.ItemsSource = slike;
        }

    }

    internal class SlovaricaItem
    {
        public string Image { get; set; }
    }
}