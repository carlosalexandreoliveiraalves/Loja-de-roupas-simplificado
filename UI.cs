using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao1.UI
{
    internal class Class1
    {
        class Menu
        {
            public int menu()
            {
                Console.Write("\n   --------Menu---------\n 1.Adicionar Produto \n 2.Adicionar Categoria \n 3.Adicionar Cliente \n 4.Realizar Venda \n 5.Remover Produto \n 6.Remover Categoria \n 7.Remover Cliente \n 8.Mostrar dados registrados \n 9.Sair do programa \n\n");
                int opcao = int.Parse(Console.ReadLine());
                return (opcao);
            }
        }
    }
}
