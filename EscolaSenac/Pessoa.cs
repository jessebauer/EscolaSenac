using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscolaSenac
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

        public Date dtNascimento
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

        public System.Collections.Generic.List<T> frequencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float mediaDeNotas
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<T> notas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public matricula cadastraPessoa()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<T> consultarNotas()
        {
            throw new System.NotImplementedException();
        }

        public bool validaCpf()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<T> consultaFreq()
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

    public class CopyOfProfessor : Pessoa
    {
        public int salario
        {
            get => default;
            set
            {
            }
        }

        public void cadastraNota()
        {
            throw new System.NotImplementedException();
        }

        public void getSalario()
        {
            throw new System.NotImplementedException();
        }

        public void cadastraFreq()
        {
            throw new System.NotImplementedException();
        }
    }
}