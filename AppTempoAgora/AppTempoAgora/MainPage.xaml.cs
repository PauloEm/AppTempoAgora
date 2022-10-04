using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppTempo.Model;
using AppTempo.Services;

namespace AppTempo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Previsão do Tempo";
            this.BindingContext = new Tempo();
        }

        private async void btnPrevisao_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cidadeEntry.Text))
                {
                    Tempo previsaoDoTempo = await DataServices.GetPrevisaoDoTempo(cidadeEntry.Text);
                    this.BindingContext = previsaoDoTempo;
                    btnPrevisao.Text = "Nova Previsão";
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
