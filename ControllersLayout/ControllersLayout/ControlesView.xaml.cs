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
    public partial class ControlesView : ContentPage
    {
        public ControlesView()
        {
            InitializeComponent();
            this.botongenerar.Clicked += Botongenerar_Clicked;
        }

        private void Botongenerar_Clicked(object sender, EventArgs e)
        {
            int botones = int.Parse(this.cajabotones.Text);
            this.contenedor.Children.Clear();

            for(int i=1; i <= botones; i++)
            {
                Button boton = new Button();
                boton.Text = "boton " + i;
                boton.HorizontalOptions = LayoutOptions.Center;
                this.contenedor.Children.Add(boton);
            }
        }
    }
}