using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class AutLivModel
    {
        private int _codigo1;
        private int _codigo2;

        public int CodLiv
        {
            get { return _codigo1; }
            set { _codigo1 = value; }

        }

        public int CodAut
        {
            get { return _codigo2; }
            set { _codigo2 = value; }

        }

    }
}
