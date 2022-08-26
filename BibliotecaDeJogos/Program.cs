using System;
using BlbliotecaDeJogos.Classes;
using System.Collections.Generic;

namespace BlbliotecaDeJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando página de entrada 

            List<Jogo> ListadeJogo = new List<Jogo>();

            while (true)
            {
                Console.WriteLine("======= BIBLIOTECA DE JOGOS =======");
                Console.WriteLine("");
                Console.WriteLine("1 - ADICIONAR JOGO");
                Console.WriteLine("2 - LISTAR JOGOS");
                Console.WriteLine("3 - EDITAR JOGO");
                Console.WriteLine("4 - REMOVER JOGO");
                Console.WriteLine("");
                Console.Write("Opção: ");
                String opcao = Console.ReadLine();

                bool resultado;

                if (opcao == "1")
                {
                    resultado = AdicionarJogo(ListadeJogo);

                    if (resultado == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Cadastrado com Sucesso!");
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Erro no Cadastro");
                        Console.WriteLine("Pressione qualquer tecla para continuar!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (opcao == "2")
                {
                    resultado = ListarJogos(ListadeJogo);
                }
                else if (opcao == "3")
                {
                    resultado = EditarJogo(ListadeJogo);

                }
                else if (opcao == "4")
                {
                    resultado = DeletarJogo(ListadeJogo);

                }
            }
        }
        public static bool AdicionarJogo(List<Jogo> ListadeJogo)
        {
            Console.Clear();
            Console.Write("Título: ");
            String titulo = Console.ReadLine();
            Console.Write("Gênero: ");
            String genero = Console.ReadLine();
            Console.Write("Ano de Lançamento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número máximo de jogadores: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota da crítica: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (genero == "") return false;
            if (ano < 1950 || ano > 2023) return false;
            if (maxJogadores < 1) return false;
            if (metacritic > 100) return false;

            Jogo novojogo = new Jogo(titulo, ano, genero, maxJogadores, metacritic);

            ListadeJogo.Add(novojogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos(List<Jogo> ListadeJogo)
        {
            Console.Clear();
            Console.WriteLine("JOGOS ADICIONADOS: ");
            Console.WriteLine("");

            foreach (Jogo jogo in ListadeJogo)
            {
                Console.Write("Jogo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Gênero: ");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Ano de lançamento: ");
                Console.WriteLine(jogo.getAno());
                Console.Write("Número máximo de jogadores: ");
                Console.WriteLine(jogo.getMaxJogadores());
                Console.Write("Nota: ");
                Console.WriteLine(jogo.getMetacritic());
                Console.WriteLine("================================================================================================");
                Console.WriteLine("");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();

            return true;
        }
        public static bool DeletarJogo(List<Jogo> ListadeJogo)
        {
            Console.Clear();
            Console.Write("Digite o título do jogo a ser deletado: ");
            String jogoDeletar = Console.ReadLine();

            foreach (Jogo jogo in ListadeJogo)
            {
                if (jogo.getTitulo() == jogoDeletar)
                {
                    ListadeJogo.Remove(jogo);
                    Console.Clear();
                    break;
                }
            }
            return true;
        }
        public static bool EditarJogo(List<Jogo> ListadeJogo)
        {
            Console.Clear();
            Console.Write("Digite o título do jogo a ser editado: ");
            String jogoEditar = Console.ReadLine();

            foreach (Jogo jogo in ListadeJogo)
            {
                if (jogo.getTitulo() == jogoEditar)
                {
                    Console.WriteLine("");

                    Console.Write("Escolha o novo título do jogo: ");
                    String jogoEditado = Console.ReadLine();
                    jogo.setTitulo(jogoEditado);
                    Console.Write("Escolha o novo gênero do jogo: ");
                    String generoEditado = Console.ReadLine();
                    jogo.setGenero(generoEditado);
                    Console.Write("Escolha o novo ano de lançamento do jogo: ");
                    int anoEditada = Convert.ToInt32(Console.ReadLine());
                    jogo.setAno(anoEditada);
                    Console.Write("Escolha a nova quantidade de jogadores do jogo: ");
                    int jogadoresEditado = Convert.ToInt32(Console.ReadLine());
                    jogo.setAno(jogadoresEditado);
                    Console.Write("Escolha a nova nota da crítica: ");
                    int metacriticEditado = Convert.ToInt32(Console.ReadLine());
                    jogo.setMetacritic(metacriticEditado);
                    Console.Clear();
                }
            }
            return true;
        }
    }
}