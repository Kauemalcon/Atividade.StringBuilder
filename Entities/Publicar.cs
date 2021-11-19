using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.EnumeracaoStringBuilders.Entities
{
    class Publicar
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Contente { get; set; }
        public int Curtidas { get; set; }
        public List<Comentar> Comentarios { get; set; } = new List<Comentar>();

        public Publicar()
        {

        }

        public Publicar(DateTime momento, string titulo, string contente, int curtidas)
        {
            Momento = momento;
            Titulo = titulo;
            Contente = contente;
            Curtidas = curtidas;
        }

        public void AddComentario(Comentar comentar)
        {
            Comentarios.Add(comentar);
        }

        public void RemoverComentario(Comentar comentar)
        {
            Comentarios.Remove(comentar);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Contente);
            sb.AppendLine("Comentarios:");
            foreach (Comentar c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();

        }
    }
}
