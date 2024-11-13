using CadastroEventosApp.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventosApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            var evento = new Evento
            {
                Nome = nomeEventoEntry.Text,
                DataInicio = dataInicioPicker.Date,
                DataTermino = dataTerminoPicker.Date,
                NumeroParticipantes = int.Parse(numeroParticipantesEntry.Text),
                Local = localEventoEntry.Text,
                CustoPorParticipante = double.Parse(custoParticipanteEntry.Text)
            };

            await Navigation.PushAsync(new ResumoEventoPage(evento));
        }
    }
}
