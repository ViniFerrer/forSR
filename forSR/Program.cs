using forSR.components;
using forSR.models.ListaModel;
using forSR.models.PessoaModel;

namespace SrFunctions
{

    class functions
    {
        public static void Main(string[] args)
        {
            char escolha;

            Console.WriteLine("Informe a letra da sua opção:");
            Console.WriteLine("a = forEach || b = for || c = while || d = doWhile || e = classe instaciada || f = lista");

            escolha=char.Parse(Console.ReadLine());
            
            switch (escolha)
            {
                case 'a':
                    ForEach.ForEach1();
                    break;
                case 'b':
                    For1.for1();
                    break;
                case 'c':
                    While1.while1();
                    break;
                case 'd':
                    DoWhile1.doWhile();
                    break;
                case 'e':
                    Pessoa pessoa1 = new Pessoa("Vinicius", 18);
                    Console.WriteLine("pessoa1 Nome = {0} Idade = {1}", pessoa1.Nome, pessoa1.Idade);
                    break;
                case 'f':
                    List<Produto> listaProdutos = new List<Produto>();
                    Produto produto1 = new Produto();
                    Produto produto2 = new Produto();
                    produto1.Nome = "Maca";
                    produto1.Quantidade = 100;
                    produto2.Nome = "Banana";
                    produto2.Quantidade = 100;
                    listaProdutos.Add(produto1);
                    listaProdutos.Add(produto2);
                        foreach (Produto Produto in listaProdutos)
                        {
                          Console.WriteLine(Produto.Nome);
                          Console.WriteLine(Produto.Quantidade);
                        }
                    break;
                default:
                    Console.WriteLine("Você não escolheu nenhuma opção de função valida!!!");
                    break;
            }
        }
    }
}
