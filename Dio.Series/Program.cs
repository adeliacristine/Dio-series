using System;

namespace Dio.Series
{

    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaousuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaousuario();
            }
            Console.WritLine("Obrigado pór utilizar nossos serviços.");
            Console.ReadLine();
        }
private static void ExcluirSeries()
{
Console.WriteLine("digite o id da serie:");
int indiceSerie= int.Parse(Console.ReadLine());
repositorio.Exclui(indiceSerie);
}

private static void VisualizarSerie()
{
Console.WriteLine("digite o id da serie:");

var serie = repositorio.RetornaPorId(indiceSerie);
Console.WriteLine(serie);
}




        private static void AtualizarSeries()
        {
            Console.WriteLine("Digite o id da série:");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título:");
            int entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição");
            int entradaDescricao = Console.ReadLine();

            Serie novaSere = new Serie(id:indiceSerie,
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entredaAno,
            descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }



        private static void ListarSeries()
        {
            Console.WriteLine("Listar Series");
            var lista = repositorio.Lista;
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }


        private static void InserirSeries()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título:");
            int entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição");
            int entradaDescricao = Console.ReadLine();

            Serie novaSere = new Serie(id: repositorio.ProximoId(),
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entredaAno,
            descricao: entradaDescricao);

            repositorio.Inserie(novaSerie);

        }

        private static string ObterOpcaousuario()
        {
            Console.WriteLine();
            Console.Write("")
        }


    }
}
