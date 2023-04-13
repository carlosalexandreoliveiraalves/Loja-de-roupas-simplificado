O Sistema de Gerenciamento de Vendas de Loja de Roupas (contido no arquivo main.cs dentro da pasta Main) possui nove funcionalidades principais:

  *Adicionar Produto: irá adicionar um novo produto a lista. Cada produto deve conter um nome, uma descrição, uma categoria e um preço (usando ponto invés de vírgula para número decimal). A categoria deve ser uma registrada na lista de categorias, pois, caso contrário, o produto não será cadastrado
  
  *Adicionar Categoria: irá adicionar uma nova categoria a lista. Cada categoria deve conter um nome e uma descrição. Assim como todas as demais listas, a lista de categoria também começará vazia, logo é necessário registrar pelo menos uma categoria antes de começar a informar um produto.
  
  *Adicionar Cliente: irá adicionar um novo cliente a lista. Cada cliente deve conter um nome, um sobrenome, um endereço e um telefone.
  
  *Realizar Venda: essa funcionalidade realiza e adiciona uma nova venda a lista. Cada categoria deve conter as informações do nome do cliente, data da venda, nome dos produtos e quantidade de cada produto. A lista também armazena os preços de cada produto e calcula o valor total, mas internamente, sem depender do usuário. Se o cliente não estiver na lista, a venda é parada imediamente. Se um produto inválido for informado, o produto alertará e voltará a pedir outro produto. Para parar de informar produtos, o usuário deve digitar "Y", mas, se não informar nenhum produto e parar logo na primeira leitura, a venda não será registrada.
  
  *Remover Produto: remove o primeiro produto da lista e a reordena.
  
  *Remover Categoria: remove a primeira categoria da lista e a reordena.
  
  *Remover Clientes: remove o primeiro cliente da lista e a reordena.
  
  *Mostrar Dados Registrados: imprime todos os produtos, categorias, clientes e vendas que foram registrados. Caso não haja nada em alguma das listas, imprime uma mensagem alertando que nenhum(a) produto/categoria/cliente/venda foi informado(a)
  
  *Finalizar programa: para o loop do menu e encerra o programa dessa forma.

Para executar o sistema, abra a pasta GamificaçãoSistema usando o Visual Studio e execute o arquivo Gamificação1.csproj para executar. Se a build falhar, continue a execução pois o código tá funcionando.
A pasta UI contém o método do menu e a pasta Model contém as classes básicas das listas.