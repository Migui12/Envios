using System;
using System.Security.Principal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Envio.Views.Figma;
using Envio.Views.Producto;

namespace Envio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new VFPrincipal();
            //MainPage = new VPPrincipal();
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
