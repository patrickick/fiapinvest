using FiapInvest.Models;
using System.Collections.Generic;

namespace FiapInvest.Services
{
    public class InvestidorService
    {

        public void Gravar(InvestidorModel model)
        {
            // Gravando as informações do Investidor
            // Fazer a Chamada da API Rest
        }


        public InvestidorModel Consultar(int idInvest)
        {
            // Mock para Consultar Investidor
            InvestidorModel Investidor = new InvestidorModel()
            {
                IdInvestidor = 1,
                NomeInvestidor = "Barack Obama",
                Cpf = "12345678901",
                Email = "barack.obama@gmail.com",
                DataNascimento = new System.DateTime(1965, 8, 1),
                Perfil = "Arrojado",
                ValorPatrimonio = 500,
                Telefone = "1 9989989989",
                perfis = ListarPerfis()
            };

            return Investidor;
        }


        public IList<string> ListarPerfis()
        {
            IList<string> lista = new List<string>();
            lista.Add("Conservador");
            lista.Add("Moderado");
            lista.Add("Arrojado");
            lista.Add("Arriscado");
            return lista;
        }

    }
}
