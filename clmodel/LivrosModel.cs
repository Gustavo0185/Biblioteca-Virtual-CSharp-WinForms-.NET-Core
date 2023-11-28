using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace clmodel
{
    public class LivrosModel
    {
        private int _codigo;
        private string _nome;
        private int _anopu;
        private decimal _isbn;
        private string _observacoes;
        private int _codigoEdi;
        
        
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
        public int AnoPu
        {
            get { return _anopu; }
            set { _anopu = value; }
        }

        public decimal ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public string Observacoes
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }

        public int CodigoEDi
        {
            get { return _codigoEdi; }
            set { _codigoEdi = value; }
        }

    }
}
