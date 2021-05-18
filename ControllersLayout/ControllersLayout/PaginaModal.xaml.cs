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
    public partial class PaginaModal : ContentPage
    {
        String Dato { get; set; }
        public PaginaModal()
        {
            InitializeComponent();
            this.botoncerrar.Clicked += Botoncerrar_Clicked;
        }

        private async void Botoncerrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}