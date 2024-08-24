using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envio.Views.Figma;
using Envio.Views.Oficina;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envio.Views.Producto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VPPrincipal : ContentPage
    {
        public VPPrincipal()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VFPrincipal());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VOPrincipal());
        }
    }
}