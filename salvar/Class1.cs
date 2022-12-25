using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salvar
{
    class Class1
    {
        public int CODIGO { get; set; }
        public string NOME { get; set; }
        public int IDADE { get; set; }

        public Class1 (int vcodigo, string vnome, int vidade)
        {
            this.CODIGO = vcodigo;
            this.NOME = vnome;
            this.IDADE = vidade;
        }
    }
}
