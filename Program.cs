double totalPedido = 0;

bool pedidoAberto = true;

while(pedidoAberto == true){
    Console.WriteLine("Bem vindo ao melhor sistema de gerenciamento de pedidos da Ulbra - Torres");
    Console.WriteLine("1- Adicionar item ao pedido");
    Console.WriteLine("2 - Exibir total do pedido");
    Console.WriteLine("3- Finalizar pedido e sair");
    string opcao = Console.ReadLine();

    switch(opcao){
        case "1":
        Console.WriteLine("Escolha um item do cardápio:");
        Console.WriteLine("1 - Pizza (R$30.00)");
        Console.WriteLine("2 - Hamburguer (R$15.00)");
        Console.WriteLine("3 - Refrigerante (R$5.00)");
        string escolha = Console.ReadLine();

        if(escolha == "1")
        {
            totalPedido += 30;
        }else if(escolha == "2")
        {
            totalPedido += 15;
        }else if (escolha == "3")
        {
            totalPedido += 5;
        }else
        {
            Console.WriteLine("Opção inválida");
        }
        continue;

        case "2":
        Console.WriteLine($"Total do pedido: R${totalPedido}");
        continue;

        case "3":
        Console.WriteLine("Finalizando pedido... Obrigado pela preferência!");
        pedidoAberto = false;
        break;

        default:
        Console.WriteLine("Opção inválida");
        break;
    }   
}