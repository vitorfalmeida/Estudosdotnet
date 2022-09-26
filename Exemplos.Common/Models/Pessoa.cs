using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Common.Models
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(String Nome, int Idade){
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public void apresentacao(){
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}