using System;
using Atividade.EnumeracaoStringBuilders.Entities;

namespace Atividade.EnumeracaoStringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentar c1 = new Comentar("Tenha uma boa viajem");
            Comentar c2 = new Comentar("Nossa isso é maravilhoso");
            Publicar p1 = new Publicar(DateTime.Parse("21/06/2021 13:05:44"),
                    "Viajando para a Nova Zelandia",
                    "Eu estou indo visitar esse país incrível!",
                    12);
            p1.AddComentario(c1);
            p1.RemoverComentario(c2);

            Comentar c3 = new Comentar("Boa noite, aproveita!");
            Comentar c4 = new Comentar("Que a força esteja com você!");
            Publicar p2 =new Publicar(DateTime.Parse("28/07/2018 23:14:19"),
                    "Boa noite pessoal!",
                    "Vejo você amanhã!",
                    5);
            p2.AddComentario(c3);
            p2.RemoverComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
