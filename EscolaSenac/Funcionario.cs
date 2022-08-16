using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscolaSenac
{
    public class Funcionario:Pessoa
    {
        public float salario
        {
            get => default;
            set
            {
            }
        }

        public DateTime horasTrabalhadas
        {
            get => default;
            set
            {
            }
        }

        public bool cadastraFreq()
        {
            throw new System.NotImplementedException();
        }

        public bool cadastraNota()
        {
            throw new System.NotImplementedException();
        }

        public float getSalario()
        {
            throw new System.NotImplementedException();
        }

        public bool registrarPonto()
        {
            throw new System.NotImplementedException();
        }
    }
}