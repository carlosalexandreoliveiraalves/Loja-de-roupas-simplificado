using System;
using System.Collections.Generic;
using Gamificação1.Model.Model;
using Gamificacao1.UI.Menu;

namespace Gamificação1
{
    internal class Program
    {
        static void Main(string[] args) //Por favor, ignorar os erros que dizem que os valores podem ser nulos
        {
            Console.WriteLine("\n\n\t\t---Sistema de Gerenciamento de Vendas de Loja de Roupas---\n");
            List<Gamificação1.Model.Model.Produto> listaProduto = new List<Gamificação1.Model.Model.Produto>();
            int numeroProduto = 0; //Registra quantos dados tem na lista de produtos
            List<Gamificação1.Model.Model.Categoria> listaCategoria = new List<Gamificação1.Model.Model.Categoria>();
            int numeroCategoria = 0;
            List<Gamificação1.Model.Model.Cliente> listaCliente = new List<Gamificação1.Model.Model.Cliente>();
            int numeroCliente = 0;
            List<Gamificação1.Model.Model.Venda> listaVenda = new List<Gamificação1.Model.Model.Venda>();
            int numeroVenda = 0;
            int opcao = 0;
            bool check = false; //Variável booleana para todos os testes abaixos, basicamente uma variável flag
            while (opcao != 9)
            {
                opcao = Gamificacao1.UI.Class1.Menu.menu();
                switch (opcao)
                {
                    case (1): //Adicionar Produto
                        Gamificação1.Model.Model.Produto newProd = new();
                        Console.Write("Informe o nome do novo produto: ");
                        newProd.nome = Console.ReadLine();
                        Console.Write("Informe a descrição: ");
                        newProd.descricao = Console.ReadLine();
                        Console.Write("Informe o preço: ");
                        newProd.preco = int.Parse(Console.ReadLine());
                        Console.Write("Informe a categoria: ");
                        newProd.categoria = Console.ReadLine();
                        foreach (Gamificação1.Model.Model.Categoria i in listaCategoria)
                        {
                            if (i.nome == newProd.categoria)
                                check = true;
                        }
                        if (check == true)
                        {
                            listaProduto.Add(newProd);
                            numeroProduto++;
                        }
                        else
                        {
                            Console.WriteLine("\n *Categoria do produto inválida!");
                        }
                        check = false; //resetando o check
                        break;
                    case (2): //Adicionar Categoria
                        Gamificação1.Model.Model.Categoria newCat = new();
                        Console.Write("Informe o nome da nova categoria: ");
                        newCat.nome = Console.ReadLine();
                        Console.Write("Informe a descrição: ");
                        newCat.descricao = Console.ReadLine();
                        listaCategoria.Add(newCat);
                        numeroCategoria++;
                        break;
                    case (3): //Adicionar Cliente
                        Gamificação1.Model.Model.Cliente newClie = new();
                        Console.Write("Informe o nome do novo cliente: ");
                        newClie.nome = Console.ReadLine();
                        Console.Write("Informe o sobrenome: ");
                        newClie.sobrenome = Console.ReadLine();
                        Console.Write("Informe o endereço: ");
                        newClie.endereco = Console.ReadLine();
                        Console.Write("Informe o telefone: ");
                        newClie.telefone = int.Parse(Console.ReadLine());
                        listaCliente.Add(newClie);
                        numeroCliente++;
                        break;
                    case (4): //Realizar Venda
                        Gamificação1.Model.Model.Venda newVen = new(); //Variável intermediária para Vendas
                        newVen.preco = new List<float> { }; //Não sei porque precisa disso
                        newVen.produtos = new List<string> { }; //mas por causa disso
                        newVen.quantidade = new List<int> { }; // funciona
                        string produto; //Variável intermediária para newVen.Produtos
                        int quantidade = 0; //Variável intermediária para .quantidade
                        int quantProdutos = 0; //Variável p/ medir quantos produtos
                        Console.Write("Informe o nome do cliente que está realizando a compra: ");
                        newVen.cliente = Console.ReadLine();
                        foreach (Gamificação1.Model.Model.Cliente i in listaCliente)
                        { //Teste se tem cliente
                            if (i.nome == newVen.cliente)
                                check = true; //Usando check p/ saber se tem cliente
                        }
                        if (check != true)
                        {
                            Console.WriteLine("\n *Cliente inválido!"); //Se não tiver
                        }
                        else
                        {
                            check = false; //Se tiver
                            Console.Write("Informe a data da venda: ");
                            newVen.dataVenda = Console.ReadLine(); //Leitura de data
                            for (int i = 1; i > 0; i++)
                            { //Loop dos produtos
                                Console.Write("Informe produto (digite Y para parar de informar produtos): ");
                                produto = Console.ReadLine();
                                if (produto == "Y")
                                { //Opção "Y" p/ sair do loop
                                    i = -20; //Pra encerrar o loop
                                }
                                else
                                {
                                    foreach (Gamificação1.Model.Model.Produto j in listaProduto)
                                    { //Teste se tem produto
                                        if (j.nome == produto)
                                        {
                                            check = true;
                                            newVen.preco.Add(j.preco);
                                        }
                                    }
                                    if (check == true)
                                    { //Se tiver
                                        newVen.produtos.Add(produto);
                                        Console.Write("Informe quantidade do produto: ");
                                        quantidade = int.Parse(Console.ReadLine());
                                        newVen.quantidade.Add(quantidade);
                                        quantProdutos++;
                                    }
                                    else
                                    { //Se não tiver
                                        Console.WriteLine("\n *Produto informado inválido!");
                                    }
                                    check = false; //Resetando o check
                                }
                            } //Fechando o loop de produtos
                            for (int k = 0; k < quantProdutos; k++)
                            {
                                newVen.valorTotal = (newVen.valorTotal + (newVen.preco[k] * newVen.quantidade[k]));
                            } //Associando o valor total
                            if (quantProdutos != 0)
                            {
                                listaVenda.Add(newVen); //Adiciona newVen a Lista de Vendas
                                numeroVenda++; //Aumentando o numero de vendas
                                Console.WriteLine(" *Venda realizada");
                            }
                            else
                            {
                                Console.WriteLine(" *Nenhum produto foi informado, venda não realizada");  //Se não tiver o produto informado
                            }
                        } //Fechando o else se tiver cliente
                        break;
                    case (5): //Remover Produto
                        if (!(numeroProduto == 0))
                        {
                            listaProduto.Remove(listaProduto[0]);
                            numeroProduto--;
                            Console.WriteLine("\n *O primeiro produto da lista foi removido!");
                        }
                        else
                        {
                            Console.WriteLine("\nNão há nenhum produto na lista atualmente\n");
                        }
                        break;
                    case (6): //Remover Categoria
                        if (!(numeroCategoria == 0))
                        {
                            listaCategoria.Remove(listaCategoria[0]);
                            numeroCategoria--;
                            Console.WriteLine("\n *A primeira categoria da lista foi removida!");
                        }
                        else
                        {
                            Console.WriteLine("\nNão há nenhuma categoria na lista atualmente\n");
                        }
                        break;
                    case (7): //Remover Cliente
                        if (!(numeroCliente == 0))
                        {
                            listaCliente.Remove(listaCliente[0]);
                            numeroCliente--;
                            Console.WriteLine("\n *O primeiro cliente da lista foi removido!");
                        }
                        else
                        {
                            Console.WriteLine("\nNão há nenhum cliente na lista atualmente\n");
                        }
                        break;
                    case (8): //Mostrar dados registrados
                        Console.WriteLine("----------Produtos----------");
                        if (numeroProduto == 0)
                        {
                            Console.WriteLine("\n\n Não há nenhum produto na lista atualmente\n");
                        }
                        else
                        {
                            for (int i = 0; i < numeroProduto; i++)
                            {
                                Console.WriteLine("\n -Produto " + (i + 1) + "\n\tNome do Produto: " + (listaProduto[i].nome) + " | Descrição do Produto: " + listaProduto[i].descricao + "\n\tCategoria do produto: " + listaProduto[i].categoria + " | Valor do Produto: " + listaProduto[i].preco);
                            }
                        }
                        Console.WriteLine("----------Categorias----------");
                        if (numeroCategoria == 0)
                        {
                            Console.WriteLine("\n\n Não há nenhuma categoria na lista atualmente\n");
                        }
                        else
                        {
                            for (int i = 0; i < numeroCategoria; i++)
                            {
                                Console.WriteLine("\n -Categoria " + (i + 1) + "\n\tNome da Categoria: " + listaCategoria[i].nome + " | Descrição da Categoria: " + listaCategoria[i].descricao);
                            }
                        }
                        Console.WriteLine("----------Clientes----------");
                        if (numeroCliente == 0)
                        {
                            Console.WriteLine("\n\n Não há nenhum cliente na lista atualmente\n");
                        }
                        else
                        {
                            for (int i = 0; i < numeroCliente; i++)
                            {
                                Console.WriteLine("\n -Cliente " + (i + 1) + "\n\tNome do Cliente: " + (listaCliente[i].nome) + " " + (listaCliente[i].sobrenome) + " | Endereço: " + listaCliente[i].endereco + " | Telefone: " + listaCliente[i].telefone);
                            }
                        }
                        Console.WriteLine("----------Vendas----------");
                        if (numeroVenda == 0)
                        {
                            Console.WriteLine("\n\n Não há nenhuma venda registrada atualmente\n");
                        }
                        else
                        {
                            for (int i = 0; i < numeroVenda; i++)
                            {
                                Console.WriteLine("\n -Venda " + (i + 1) + "\n\tNome do Cliente: " + (listaVenda[i].cliente) + " | Valor Total: " + (listaVenda[i].valorTotal) + " | Data: " + listaVenda[i].dataVenda);
                            }
                        }
                        break;
                    case (9): //Sair do Programa
                        Console.WriteLine("\n ...Finalizando programa...");
                        break;
                    default: //Se apertar qualquer outra tecla
                        Console.WriteLine("\n *Opção inválida* \n");
                        break;
                }
            }
        }
    }
}