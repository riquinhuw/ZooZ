using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooZ.Repositorios;

namespace ZooZ
{
    /*YO povo lindo, bem como todos sabem sou fã de "comentarios" então vou encher o codigo com eles, MUAH MUAH MUAH   
     * 
     * Bem temos duas semanas para terminar tudo, começando hoje ( 16/11/2017)
     * Vamos dar tudo de nos nesse JOB que vai ser sucesso, tão grande que iremos estagiar o Zoo de Dois Irmãos, gogog!
     * 
     * Depois Farei uma "Quadro" para por como anda o nosso desenvolvimento.
     * 
     * Para Duvidas de o que fazer é só entrar no Disord, lá terá todas as classes e metodos basicos necessarios
     * 
     * Metas extendidas: Fazer no Windows forms e com mapinha e tudo !!!! Até com sistema de cliente fidelidade, caixa e pá :)
     * 
     * MÃOS A OBRA, pera quero dizer, DEDOS NO TECLADO!!! 
     * 
    */
    class Program

    {   // Repositorios com os metodos CIDA com o BD
        public static RepositorioHabitat repHabitat = new RepositorioHabitat();
        public static RepositorioRecurso repRecurso = new RepositorioRecurso();
        public static RepositorioAnimal repAnimal = new RepositorioAnimal();
        public static RepositorioFuncionario repFuncionario = new RepositorioFuncionario();

        static void Main(string[] args)//PODEM MUDAR O PROGRAM PARA TESTAR SUAS APLIACAÇÕES, fiquem tranquilos!
        {
            int menu = 0;//int para index do Swtich do Menu inicial que irá indicar os outros menus especificios de cada classe.
            bool looping = true;//Bool para continuar o looping do menu inicial.

            do
            {
                Logomarca();
                Console.WriteLine("Seleciona a opção que deseja:");
                Console.WriteLine("\n1 - Funcionários");
                Console.WriteLine("2 - Habitat");
                Console.WriteLine("3 - Recursos");
                Console.WriteLine("4 - Animais");
                Console.Write("\nDigite a opção:");
                
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:// Menu Funcionario
                        MenuFuncionario();
                        break;

                    case 2://Menu Habitat
                        MenuHabitat();
                        break;

                    case 3:// Menu Recurso
                        MenuRecurso();
                        break;

                    case 4:// MEnu Animal
                        MenuAnimal();
                        break;

                    case 5://sair
                        string respostaDoUsuario;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuario = Console.ReadLine().ToUpper();
                        if (respostaDoUsuario == "S") { looping = false; }
                        break;

                    case 007:// Hum...

                        break;

                    default://Error default 404 nothing found
                        Console.WriteLine("Digite uma opção valida tente novamente\npress any key to continue");
                        Console.ReadKey();
                        break;
                }

            }while(looping);


        }

        static public void Logomarca()
        {
            //Vitor do gera
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ________   ___ _____");
            Console.WriteLine(@"|__  / _ \ / _ \__  /");
            Console.WriteLine(@"  / / | | | | | |/ / ");
            Console.WriteLine(@" / /| |_| | |_| / /_ ");
            Console.WriteLine(@"/____\___/ \___/____|");
            Console.WriteLine("\n\n");
            Console.ResetColor();
        }

        static public void MenuHabitat()
        {
            bool looping = true;
            do
            {
                Logomarca();
                //vitur do gera
                int caseSwitch;
                Console.WriteLine("Seleciona a opção que deseja:");
                Console.WriteLine("1 - Listar os Habitats");
                Console.WriteLine("2 - Alterar o nome do Habitat(id)");
                Console.WriteLine("3 - Inserir Habitat");
                Console.WriteLine("4 - Remover");
                Console.WriteLine("5 - Sair");
                Console.Write("\n\nDigite uma opção:");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1://LISTAR HABITATS
                        Logomarca();
                        repHabitat.Listar();
                        break;

                    case 2:// ALTERAR
                        Logomarca();
                        int idAlterar;
                        string nome;
                        Console.WriteLine("Digite o Id do Habitat:");
                        idAlterar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do Habitat:");
                        nome = Console.ReadLine();
                        repHabitat.Alterar(idAlterar, nome); 
                        break;

                    case 3://INSERIR HABITAT
                        Logomarca();
                        string nomeHabitat;
                        int idRecurso;
                        Console.WriteLine("Insira o nome do Habitat");
                        nomeHabitat = Console.ReadLine();
                        Console.WriteLine("Digite o id do recurso que você deseja inserir:");
                        idRecurso = int.Parse(Console.ReadLine());
                        Habitat h1 = new Habitat(nomeHabitat, idRecurso);
                        repHabitat.Inserir(h1);
                        break;

                    case 4://Remover Habitat
                        Logomarca();
                        int idRemover;
                        Console.WriteLine("Digite o Id do Habitat que deseja remover:");
                        idRemover = int.Parse(Console.ReadLine());
                        repHabitat.Remover(idRemover);
                        break;

                    case 5://sair
                        string respostaDoUsuario;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuario = Console.ReadLine().ToUpper();
                        if (respostaDoUsuario == "S") { looping = false; }
                        break;

                    default:
                        Console.WriteLine("DIGITE UM NUMERO CORRETO SEU ANIMAL RACIONAL");
                        break;
                }
            } while (looping);

        }

        static public void MenuAnimal()
        {
            bool looping = true;
            do
            {
                Logomarca();
                //vitur do gera
                int caseSwitch;
                Console.WriteLine("Seleciona a opção que deseja:");
                Console.WriteLine("1 - Listar um animal");
                Console.WriteLine("2 - Alterar o nome do animal(id)");
                Console.WriteLine("3 - Alterar a espécie do animal");
                Console.WriteLine("4 - Alterar a idade de um animal");
                Console.WriteLine("5 - Inserir um novo animal");
                Console.WriteLine("6 - Remover um animal");
                Console.WriteLine("7 - Sair");
                Console.Write("\n\nDigite uma opção:");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1://LISTAR HABITATS
                        Logomarca();
                        repAnimal.Listar();
                        break;

                    case 2:// ALTERAR O NOME DO ANIMAL
                        Logomarca();
                        int idAlterarAnimal;
                        string nomeAnimal;
                        Console.WriteLine("Digite o Id do animal:");
                        idAlterarAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do animal:");
                        nomeAnimal = Console.ReadLine();
                        repAnimal.AlterarNome(idAlterarAnimal, nomeAnimal);
                        break;

                    case 3://ALTERAR A ESPÉCIE DE UM ANIMAL
                        Logomarca();                        
                        int idAlterarEspecieAnimal;
                        string especieAnimal;
                        Console.WriteLine("Digite o Id do animal, que terá a sua espécie alterada:");
                        idAlterarEspecieAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do animal, que terá a sua espécie alterada:");
                        especieAnimal = Console.ReadLine();
                        repAnimal.AlterarEspecie(idAlterarEspecieAnimal, especieAnimal);
                        break;

                    case 4://ALTERAR A IDADE DE UM ANIMAL
                        Logomarca();
                        int idAlterarIdadeAnimal;
                        int idadeAnimal;
                        Console.WriteLine("Digite o Id do animal, que terá a sua idade alterada:");
                        idAlterarIdadeAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a idade alterada do animal:");
                        idadeAnimal = int.Parse(Console.ReadLine());
                        repAnimal.AlterarIdade(idAlterarIdadeAnimal, idadeAnimal);
                        break;

                    case 5://INSERIR UM NOVO ANIMAL
                        Logomarca();
                        Animal animal01 = new Animal();
                        Console.WriteLine("Insira o id do animal");
                        animal01.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o nome do animal");
                        animal01.Nome = Console.ReadLine();
                        Console.WriteLine("Insira a idade do animal");
                        animal01.Idade = int.Parse(Console.ReadLine());                       
                        break;

                    case 6://REMOVER UM ANIMAL
                        Logomarca();
                        int idRemoverAnimal;
                        Console.WriteLine("Digite o Id do animal que deseja remover:");
                        idRemoverAnimal = int.Parse(Console.ReadLine());
                        repHabitat.Remover(idRemoverAnimal);
                        break;


                    case 7://sair
                        string respostaDoUsuarioMenuAnimal;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuarioMenuAnimal = Console.ReadLine().ToUpper();
                        if (respostaDoUsuarioMenuAnimal == "S") { looping = false; }
                        break;

                    default:
                        Console.WriteLine("DIGITE UM NUMERO CORRETO SEU ANIMAL RACIONAL");
                        break;
                }
            } while (looping);


        }

        static public void MenuRecurso()
        {
            //CODIGO DO Re´que da em CURSO hahahahah

        }

        static public void MenuFuncionario()
        {
            //Codigo que funciona no Mario, FUncioMario, HAHAHAHAHAH

        }
    }
}
