using CadastroEventosApp.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventosApp
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            nomeEventoLabel.Text = evento.Nome;
            dataInicioLabel.Text = evento.DataInicio.ToString("dd/MM/yyyy");
            dataTerminoLabel.Text = evento.DataTermino.ToString("dd/MM/yyyy");
            numeroParticipantesLabel.Text = evento.NumeroParticipantes.ToString();
            localLabel.Text = evento.Local;
            custoParticipanteLabel.Text = evento.CustoPorParticipante.ToString("C");
            duracaoLabel.Text = evento.DuracaoEmDias.ToString();
            custoTotalLabel.Text = evento.CustoTotal.ToString("C");
        }
    }
}
