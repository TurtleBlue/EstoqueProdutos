namespace udemy_EstoqueProdutos
{
    /* Fazer um programa para ler os dados de um estoque (nome, preço e quantidade no estoque). 
     * Em seguida:
     * - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
     * - Realizar uma entrada no estoque e mostrar novamente os dados do produto
     * - Realizar uma saída no estoque e mostrar novamente os dados do produto
     * 
     * Para resolver esse problema, deve-se criar uma classe.
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, quantidade, loop = 1;
            string nome;
            double preco;

            Console.WriteLine("DIGITE OS DADOS DO PRODUTO\n");

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            do
             {
                Console.WriteLine($"Dados do produto: {produto.Nome}, {produto.Preco}, {produto.Quantidade}, Total:R${produto.Quantidade * produto.Preco:n2}");
                Console.WriteLine("Deseja adicionar ou remover produtos ao estoque?");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("4 - Sair");
                opcao = int.Parse(Console.ReadLine());
                 switch (opcao)
                 {
                     case 1:
                         Console.WriteLine("Quantos produtos deseja adicionar?");
                         produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
                         Console.Clear();
                         Console.WriteLine($"Novos dados do produto: " +
                             $"Produto: {produto.Nome}, " +
                             $"Preco: {produto.Preco}, " +
                             $"Quantidade: {produto.Quantidade}, " +
                             $"Total:R${produto.ValorTotalEmEstoque():n2}");
                         break;
                     case 2:
                         Console.WriteLine("Quantos produtos deseja remover?");
                         produto.RemoverProdutos(int.Parse(Console.ReadLine()));
                         Console.WriteLine($"Novos dados do produto: " +
                             $"Produto: {produto.Nome}, " +
                             $"Preco: {produto.Preco}, " +
                             $"Quantidade: {produto.Quantidade}, " +
                             $"Total:R${produto.Quantidade * produto.Preco:n2}");
                         break;
                        case 4:
                         Console.Write($"Certo, saindo do programa. \n" +
                              $"O relatório final ficou em: " +
                              $"Produto: {produto.Nome}, " +
                              $"Preco: {produto.Preco}, " +
                              $"Quantidade: {produto.Quantidade} " +
                              $"Total:R${produto.Quantidade * produto.Preco:n2}\n");
                         loop = 0;
                         break;
                     default:
                         Console.WriteLine("Opção inválida, tente novamente");
                         Console.ReadKey();
                         Console.Clear();
                         break;
                 }
             } while (loop == 1); 
        }
    }
}