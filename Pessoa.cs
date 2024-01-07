using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_POO
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value=="")
                {
                    throw new ArgumentException("O valor é vazio!");
                }
                    _nome = value;
            }
        }
        public int Idade { get; set; }

        private string _sexo;
        public string Sexo
        {
            get
            {
                return _sexo.ToUpper();
            }

            set
            {
                if(value =="masculino")
                {
                    _sexo = "masculino";
                
                }
                else if(value =="feminino")
                {
                    _sexo = "feminino";
                }
                else
                {
                   throw new ArgumentException("O sexo precisa ser feminino ou masculino"); 
                }
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Sexo: {Sexo}");
        }
    }
}