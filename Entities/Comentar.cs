using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.EnumeracaoStringBuilders.Entities
{
    class Comentar
    {
        public string Texto { get; set; }

        public Comentar()
        {

        }

        public Comentar(string texto)
        {
            Texto = texto;
        }
    }

}
