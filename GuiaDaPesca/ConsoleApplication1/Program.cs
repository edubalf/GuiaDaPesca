using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Infra.Context;
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
            new UsuarioRepository().Adicionar(new Usuario("edubalf", "123mudar", "123mudar"));
        }
    }
}
