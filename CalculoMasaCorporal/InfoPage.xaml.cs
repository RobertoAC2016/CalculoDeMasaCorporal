using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculoMasaCorporal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        private TipoInfo.Tipo _tipo;
        private MasaCorporal mc = new MasaCorporal();
        public InfoPage(TipoInfo.Tipo Tipo)
        {
            InitializeComponent();
            _tipo = Tipo;
            mc.Tipo = Tipo.ToString();
            pnlPorGenero.IsVisible = false;
            pnlPorEdad.IsVisible = false;
            pnlPorComplexion.IsVisible = false;
            if (Tipo == TipoInfo.Tipo.Genero) pnlPorGenero.IsVisible = true;
            if (Tipo == TipoInfo.Tipo.Edad) pnlPorEdad.IsVisible = true;
            if (Tipo == TipoInfo.Tipo.Complexion) pnlPorComplexion.IsVisible = true;
        }
        private async void hombre_Clicked(object sender, EventArgs e)
        {
            mc.Genero = "Hombre";
            await Navigation.PushModalAsync(new DescriptionPage(mc));
        }
        private async void mujer_Clicked(object sender, EventArgs e)
        {
            mc.Genero = "Mujer";
            await Navigation.PushModalAsync(new DescriptionPage(mc));
        }
        private async void btnEdad_Clicked(object sender, EventArgs e)
        {
            mc.Edad = txtEdad.Text;
            await Navigation.PushModalAsync(new DescriptionPage(mc));
        }
        private async void btnEctomorfo_Clicked(object sender, EventArgs e)
        {
            mc.Complexion = "Ectomorfo";
            await Navigation.PushModalAsync(new DescriptionPage(mc));
        }
        private async void btnMesomorfo_Clicked(object sender, EventArgs e)
        {
            mc.Complexion = "Mesomorfo";
            await Navigation.PushModalAsync(new DescriptionPage(mc));
        }
        private async void btnEndomorfo_Clicked(object sender, EventArgs e)
        {
            mc.Complexion = "Endomorfo";
            await Navigation.PushModalAsync(new DescriptionPage(mc));
        }
    }
}