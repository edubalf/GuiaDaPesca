using GuiaDaPesca.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Peixe peixe = new Peixe("Pacu");

            Comentario comentario = new Comentario("Peixe grande", new Usuario("edubalf", "123mudar", "123mudar"));

            peixe.IncluirComentario(comentario);

            Comentario comentarioParaRemover = new Comentario("Teste", new Usuario("edubalf", "123mudar", "123mudar"));

            peixe.RemoverComentario(comentarioParaRemover);


            Console.ReadKey();
        }
    }
}
