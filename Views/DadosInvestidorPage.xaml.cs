using FiapInvest.Models;
using System;
using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class DadosInvestidorPage : ContentPage
    {
        private int IdUsuario = 1;
        Models.InvestidorModel InvestidorModel;

        public DadosInvestidorPage()

        {
            // Adicionando o Componente para Binding da Página
            InvestidorModel = new Business.InvestidorBusiness().Consultar(IdUsuario);
            this.BindingContext =  InvestidorModel;
            
            InitializeComponent();
            ButtonGravar.Clicked += GravarInvestidorClick;
        }

        public void GravarInvestidorClick(object o, EventArgs e)
        {
            Business.InvestidorBusiness investidorBusiness = new Business.InvestidorBusiness();
            investidorBusiness.Gravar(InvestidorModel);

            DisplayAlert("Sucesso", "Investidor" + InvestidorModel.NomeInvestidor + "gravado com sucesso!","ok");
        }

    }
}
