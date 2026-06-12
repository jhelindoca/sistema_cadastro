using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemadecadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            while (opcao != 5) //!=diferente
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
                Console.ResetColor();
                Console.WriteLine("\n 1-Cadastro Animes");
                Console.WriteLine("\n 2- Cadastro de Supers");
                Console.WriteLine("\n 3-Cadastro de Séries");
                Console.WriteLine("\n 4- Cadastro de locadora de vhs");
                Console.WriteLine("\n 5-Cadastro de oficina mecânica");
                Console.WriteLine("\n 6- Cadastro de Livros");
                Console.WriteLine("\n 7-Cadastro de restaurante Cardápio");
                Console.WriteLine("\n 8- Cadastro de jogos");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("digite a opcao escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {

                    case 1:
                        cadastro_anime();
                        break;
                    case 2:
                        cadastro_supers();
                        break;
                    case 3:
                        cadastro_series();
                        break;
                    case 4:
                        cadastro_locadoradevhs();
                        break;
                    case 5:
                        cadastro_oficinamecanica();
                        break;
                    case 6:
                        cadastro_delivros();
                        break;
                    case 7:
                        cadastro_restaurantecardapio();
                        break;
                    case 8:
                        
                        break;



                }


            }




        }
        static void cadastro_anime()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░███╗░░██╗██╗███╗░░░███╗███████╗░██████╗
██╔══██╗████╗░██║██║████╗░████║██╔════╝██╔════╝
███████║██╔██╗██║██║██╔████╔██║█████╗░░╚█████╗░
██╔══██║██║╚████║██║██║╚██╔╝██║██╔══╝░░░╚═══██╗
██║░░██║██║░╚███║██║██║░╚═╝░██║███████╗██████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░");

            Console.ResetColor();
            Console.WriteLine("\n título:");
            string tituloanime = Console.ReadLine();
            Console.WriteLine("\n quantidade de episodios:");
            string qntepisodio = Console.ReadLine();
            Console.WriteLine("\n ano lançado:");
            string anolancamento = Console.ReadLine();
            Console.WriteLine("\n personagem principal:");
            string personagemprincipal = Console.ReadLine();
            Console.WriteLine("\n categoria:");
            string categoriaanime = Console.ReadLine();
            Console.WriteLine("\n classificação:");
            string classificacaoanime = Console.ReadLine();
            Console.WriteLine("\n avaliação:");
            string avaliacaoanime = Console.ReadLine();


        }



        static void cadastro_supers()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░██████╗██╗░░░██╗██████╗░███████╗██████╗░░██████╗
██╔════╝██║░░░██║██╔══██╗██╔════╝██╔══██╗██╔════╝
╚█████╗░██║░░░██║██████╔╝█████╗░░██████╔╝╚█████╗░
░╚═══██╗██║░░░██║██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗
██████╔╝╚██████╔╝██║░░░░░███████╗██║░░██║██████╔╝
╚═════╝░░╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();
            Console.WriteLine("\n nome:");
            string nomesupers = Console.ReadLine();
            Console.WriteLine("\n apelido:");
            string apelidosupers = Console.ReadLine();
            Console.WriteLine("\n data de nascimento:");
            string datanascimento = Console.ReadLine();
            Console.WriteLine("\n altura:");
            string alturasupers = Console.ReadLine();
            Console.WriteLine("\n peso:");
            string pesosupers = Console.ReadLine();
            Console.WriteLine("\n gênero:");
            string generosupers = Console.ReadLine();
            Console.WriteLine("\n descrição do traje:");
            string descricaotraje = Console.ReadLine();
            Console.WriteLine("\n habilidades:");
            string habilidadessupers = Console.ReadLine();
            Console.WriteLine("\n poderes:");
            string poderessupers = Console.ReadLine();
            Console.WriteLine("\n pontos fortes:");
            string pontosfortes = Console.ReadLine();
            Console.WriteLine("\n fraquezas:");
            string fraquezassupers = Console.ReadLine();
            Console.WriteLine("\n inimigos:");
            string inimigosssupers = Console.ReadLine();
            Console.WriteLine("\n quantidades de aliados:");
            string qntaliados = Console.ReadLine();

        }



        static void cadastro_series()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░██████╗███████╗██████╗░██╗███████╗░██████╗
██╔════╝██╔════╝██╔══██╗██║██╔════╝██╔════╝
╚█████╗░█████╗░░██████╔╝██║█████╗░░╚█████╗░
░╚═══██╗██╔══╝░░██╔══██╗██║██╔══╝░░░╚═══██╗
██████╔╝███████╗██║░░██║██║███████╗██████╔╝
╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝╚══════╝╚═════╝░");

            Console.ResetColor();
            Console.WriteLine("\n titulo:");
            string tituloserie = Console.ReadLine();
            Console.WriteLine("\n quantidade de episodio:");
            string qntepisodio = Console.ReadLine();
            Console.WriteLine("\n quantidade de temporadas:");
            string qnttemporadas = Console.ReadLine();
            Console.WriteLine("\n ano lançado:");
            string anolancado = Console.ReadLine();
            Console.WriteLine("\n personagem principal:");
            string personagemprincipal = Console.ReadLine();
            Console.WriteLine("\n vilão:");
            string vilaoserie = Console.ReadLine();
            Console.WriteLine("\n categoria:");
            string categoriaserie = Console.ReadLine();
            Console.WriteLine("\n classificação:");
            string classificacaoserie = Console.ReadLine();
        }

        static void cadastro_locadoradevhs()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

██╗░░░░░░█████╗░░█████╗░░█████╗░██████╗░░█████╗░██████╗░░█████╗░  ██████╗░███████╗
██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░░░░██║░░██║██║░░╚═╝███████║██║░░██║██║░░██║██████╔╝███████║  ██║░░██║█████╗░░
██║░░░░░██║░░██║██║░░██╗██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║  ██║░░██║██╔══╝░░
███████╗╚█████╔╝╚█████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║  ██████╔╝███████╗
╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

██╗░░░██╗██╗░░██╗░██████╗
██║░░░██║██║░░██║██╔════╝
╚██╗░██╔╝███████║╚█████╗░
░╚████╔╝░██╔══██║░╚═══██╗
░░╚██╔╝░░██║░░██║██████╔╝
░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();
            Console.WriteLine("\n titulo:");
            string titulolocadoradevhs = Console.ReadLine();
            Console.WriteLine("\n ano lançado:");
            string anolancado = Console.ReadLine();
            Console.WriteLine("\n categoria:");
            string categorialocadoravhs = Console.ReadLine();
            Console.WriteLine("\n livre ou emprestado?:");
            string livreouemprestado = Console.ReadLine();
        }

        static void cadastro_oficinamecanica()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░███████╗██╗░█████╗░██╗███╗░░██╗░█████╗░
██╔══██╗██╔════╝██║██╔══██╗██║████╗░██║██╔══██╗
██║░░██║█████╗░░██║██║░░╚═╝██║██╔██╗██║███████║
██║░░██║██╔══╝░░██║██║░░██╗██║██║╚████║██╔══██║
╚█████╔╝██║░░░░░██║╚█████╔╝██║██║░╚███║██║░░██║
░╚════╝░╚═╝░░░░░╚═╝░╚════╝░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝

███╗░░░███╗███████╗░█████╗░░█████╗░███╗░░██╗██╗░█████╗░░█████╗░
████╗░████║██╔════╝██╔══██╗██╔══██╗████╗░██║██║██╔══██╗██╔══██╗
██╔████╔██║█████╗░░██║░░╚═╝███████║██╔██╗██║██║██║░░╚═╝███████║
██║╚██╔╝██║██╔══╝░░██║░░██╗██╔══██║██║╚████║██║██║░░██╗██╔══██║
██║░╚═╝░██║███████╗╚█████╔╝██║░░██║██║░╚███║██║╚█████╔╝██║░░██║
╚═╝░░░░░╚═╝╚══════╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░╚════╝░╚═╝░░╚═╝");

            Console.ResetColor();
            Console.WriteLine("\n ordem de serviço:");
            string ordemdeservico = Console.ReadLine();
            Console.WriteLine("\n peças:");
            string pecasoficina = Console.ReadLine();
            Console.WriteLine("\n funcionários:");
            string funcionariosmecanica = Console.ReadLine();
            Console.WriteLine("\n históricos de manutenção:");
            string historicomanutencao = Console.ReadLine();
            Console.WriteLine("\n valor:");
            string valormecanica = Console.ReadLine();
            Console.WriteLine("\n data de agendamento:");
            string dataagendamento = Console.ReadLine();
            Console.WriteLine("\n nome do cliente:");
            string nomecliente = Console.ReadLine();
        }

        static void cadastro_delivros()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░");

            Console.WriteLine("\n título:");
            string titulolivro = Console.ReadLine();
            Console.WriteLine("\n ano lançado:");
            string anolancado = Console.ReadLine();
            Console.WriteLine("\n classificação:");
            string classificacaolivro = Console.ReadLine();
            Console.WriteLine("\n quantidade de páginas:");
            string qntpaginas = Console.ReadLine();
            Console.WriteLine("\n gênero:");
            string generolivro = Console.ReadLine();
            Console.WriteLine("\n autor:");
            string autorlivro = Console.ReadLine();
            Console.WriteLine("\n editora:");
            string editoralivro = Console.ReadLine();
        }

        static void cadastro_restaurantecardapio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░███████╗░██████╗████████╗░█████╗░██╗░░░██╗██████╗░░█████╗░███╗░░██╗████████╗███████╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║░░░██║██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔════╝
██████╔╝█████╗░░╚█████╗░░░░██║░░░███████║██║░░░██║██████╔╝███████║██╔██╗██║░░░██║░░░█████╗░░
██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░░██║██╔══██╗██╔══██║██║╚████║░░░██║░░░██╔══╝░░
██║░░██║███████╗██████╔╝░░░██║░░░██║░░██║╚██████╔╝██║░░██║██║░░██║██║░╚███║░░░██║░░░███████╗
╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝

░█████╗░░█████╗░██████╗░██████╗░░█████╗░██████╗░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗
██║░░╚═╝███████║██████╔╝██║░░██║███████║██████╔╝██║██║░░██║
██║░░██╗██╔══██║██╔══██╗██║░░██║██╔══██║██╔═══╝░██║██║░░██║
╚█████╔╝██║░░██║██║░░██║██████╔╝██║░░██║██║░░░░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.WriteLine("\n nome:");
            string nomecardapio = Console.ReadLine();
            Console.WriteLine("\n preço:");
            string precocardapio = Console.ReadLine();
            Console.WriteLine("\n ingredientes:");
            string ingredientescardapio = Console.ReadLine();
            Console.WriteLine("\n descrição:");
            string descricaocardapio = Console.ReadLine();
        }

    
            





        }
    }
                            