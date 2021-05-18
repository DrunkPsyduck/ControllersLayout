using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControllersLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaMenu : ContentPage
    {
        public PaginaMenu()
        {
            InitializeComponent();
            this.botonframe.Clicked += Botonframe_ClickedAsync;
            this.botonlayout.Clicked += Botonlayout_Clicked;
        }

        private async void Botonlayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutView());
        }

        private async void Botonframe_ClickedAsync(object sender, EventArgs e)
        {
            //Navegacion asincrona
            await Navigation.PushAsync(new FrameView());
        }
    }
}