using System;
using System.Globalization;

namespace Projetos_Secao_3
{
    class Quarto
    {
        public string nomeHospede { get; set; }
        public string emailHospede { get; set; }
        public int numQuarto { get; set; }

        public Quarto(string nome,string email, int quarto)
        {
            this.nomeHospede = nome;
            this.emailHospede = email;
            this.numQuarto = quarto;
        }
    }
}
