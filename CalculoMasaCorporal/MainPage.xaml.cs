using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculoMasaCorporal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void genero_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InfoPage(TipoInfo.Tipo.Genero));
        }
        private async void edad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InfoPage(TipoInfo.Tipo.Edad));
        }
        private async void complexion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InfoPage(TipoInfo.Tipo.Complexion));
        }
    }
}
