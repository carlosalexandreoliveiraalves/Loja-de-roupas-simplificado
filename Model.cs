using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificação1.Model
{

    namespace Model
    { //Classes principais
        class Produto
        { //Classe de funcionário
            public string nome;
            public string descricao;
            public string categoria;
            public float preco;

            //Função
        }

        class Categoria
        { //Classe de categoria
            public string nome;
            public string descricao;

            //Função 
        }

        class Cliente
        { //Classe de cliente
            public string nome;
            public string sobrenome;
            public string endereco;
            public int telefone;

            //Função
        }

        class Venda
        { //Classe de Venda
            public string cliente;
            public string dataVenda;
            public float valorTotal;
            public List<string> produtos;
            public List<int> quantidade;
            public List<float> preco;

            //Função
        }
    }
}
