using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSA
{
    public class Pessoa
    {
        //variaveis globais
        private string nome;
        private string email;
        private int idade;
        //metodo construtor
        public Pessoa()
        {

        }

        public void imprimirValores()
        {
            //imprimindo
        }
        public int calcularIdade(int idade)
        {
            return this.idade = idade + 1;
        }
    }
}
