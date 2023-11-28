using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class AutoresModel
    {
        private int _codigo;
        private string _nome;
        private string _pseu;
        private string _observacoes;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }

        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Pseu
        {
            get { return _pseu; }
            set { _pseu = value; }
        }
        public string Observacoes
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }

    }
}
