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
    public partial class TiposAlerta : ContentPage
    {
        public TiposAlerta()
        {
            InitializeComponent();
            this.botonsimple.Clicked += (sender, args) =>
            {
                DisplayAlert("Titulo", "Mensaje simple", "OK");
            };

            this.botonokcancel.Clicked += Botonokcancel_Clicked;
            this.botonopciones.Clicked += Botonopciones_Clicked;
            this.botonmodal.Clicked += Botonmodal_Clicked;
        }

        private async void Botonmodal_Clicked(object sender, EventArgs e)
        {
            PaginaModal modal = new PaginaModal();
            await Navigation.PushModalAsync(modal);
        }

        private async void Botonopciones_Clicked(object sender, EventArgs e)
        {
            String opciones = await DisplayActionSheet("Que empresa queries?", "cancelar", "Seleccionar uno", "Macas", "BurriKing");
            this.lblrespuesta.Text = opciones;
        }

        private async void Botonokcancel_Clicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert("pregunta....", "Real Madrid campeon de liga?", "Si", "no");

            if (respuesta == true)
            {
                this.lblrespuesta.Text = "Tu si que sabes";
            }
            else
            {
                this.lblrespuesta.Text = "No tienes ni idea";
            };
        }
    }
}