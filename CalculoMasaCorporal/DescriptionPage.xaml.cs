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
    public partial class DescriptionPage : ContentPage
    {
        private MasaCorporal _mc;
        public DescriptionPage(MasaCorporal mc)
        {
            InitializeComponent();
            _mc = mc;
            if (mc.Tipo == TipoInfo.Tipo.Genero.ToString())
            {
                lblDetail.Text = $"{mc.Tipo}: {mc.Genero}";
            }
            if (mc.Tipo == TipoInfo.Tipo.Edad.ToString())
            {
                lblDetail.Text = $"{mc.Tipo}: {mc.Edad}";
            }
            if (mc.Tipo == TipoInfo.Tipo.Complexion.ToString())
            {
                lblDetail.Text = $"{mc.Tipo}: {mc.Complexion}";
            }
        }
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            txtResultado.Text = $"Tu IMC: {float.Parse(txtPeso.Text) / (float.Parse(txtAltura.Text) * float.Parse(txtAltura.Text))} Kg";
        }
    }
}