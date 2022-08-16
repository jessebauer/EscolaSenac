using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Pessoa
    {
        public string nomeDaPessoa
        {
            get => default;
            set
            {
            }
        }

        public double cpf
        {
            get => default;
            set
            {
            }
        }

        public DateTime dtNascimento
        {
            get => default;
            set
            {
            }
        }

        public string tipoPessoa
        {
            get => default;
            set
            {
            }
        }

        public int matricula
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<String> frequencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float mediaDeNotas
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<String> notas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void cadastraPessoa()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<String> consultarNotas()
        {
            throw new System.NotImplementedException();
        }

        public bool validaCpf()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<String> consultaFreq()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Aluno : Pessoa

    {

        public float calculaMedia()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Professor:Funcionario
    {

        public void cadastraNota()
        {
            throw new System.NotImplementedException();
        }

        public void cadastraFreq()
        {
            throw new System.NotImplementedException();
        }
    }
}