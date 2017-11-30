using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public static RepositorioEgg egg = new RepositorioEgg();
        public static DAO dao = new DAO();
        public static MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID_PESSOA) FROM PESSOA", dao.Conexao);

        static void Main()//PODEM MUDAR O PROGRAM PARA TESTAR SUAS APLIACAÇÕES, fiquem tranquilos!
        {
            bool erroMenu = false;
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
                Console.WriteLine("5 - Sair");
                if (erroMenu) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Opção invalida, tente novamente"); Console.ResetColor(); erroMenu = false; }
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

                    case 2489:// Hum...

                        egg.EasterEgg();

                        break;

                    default://Error default 404 nothing found
                        erroMenu = true;
                        break;
                }

            } while (looping);
        }
        static public void Logomarca()
        {
            int minuto;
            minuto = int.Parse(DateTime.Now.ToString("mm tt"));
            //se for par
            if (minuto % 2 != 0) {

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
            else //se for ímpar
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@" ________   ___ _____");
                Console.WriteLine(@"|__  / _ \ / _ \__  /");
                Console.WriteLine(@"  / / | | | | | |/ / ");
                Console.WriteLine(@" / /| |_| | |_| / /_ ");
                Console.WriteLine(@"/____\___/ \___/____|");
                Console.WriteLine("\n\n");
                Console.ResetColor();

            }
        }

        static public void MenuHabitat()
        {
            bool erroMenu = false;
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
                if (erroMenu) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Opção invalida, tente novamente"); Console.ResetColor(); erroMenu = false; }
                Console.Write("\n\nDigite uma opção:");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1://LISTAR HABITATS
                        Logomarca();
                        repHabitat.Listar();
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
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
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
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
                        Console.WriteLine("Criado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 4://Remover Habitat
                        Logomarca();
                        int idRemover;
                        Console.WriteLine("Digite o Id do Habitat que deseja remover:");
                        idRemover = int.Parse(Console.ReadLine());
                        repHabitat.Remover(idRemover);
                        Console.WriteLine("Removido com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5://sair
                        string respostaDoUsuario;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuario = Console.ReadLine().ToUpper();
                        if (respostaDoUsuario == "S") { looping = false; }
                        break;

                    default:
                        erroMenu = true;
                        break;
                }
            } while (looping);

        }

        static public void MenuAnimal()
        {
            bool erroMenu = false;
            bool looping = true;
            do
            {
                Logomarca();
                //vitur do gera
                int caseSwitch;
                Console.WriteLine("Seleciona a opção que deseja:");
                Console.WriteLine("1 - Listar animais");
                Console.WriteLine("2 - Alterar o nome de um animal(id)");
                Console.WriteLine("3 - Alterar a espécie de um animal");
                Console.WriteLine("4 - Alterar a idade de um animal");
                Console.WriteLine("5 - Inserir um novo animal");
                Console.WriteLine("6 - Remover um animal");
                Console.WriteLine("7 - Alterar o Cuidador");
                Console.WriteLine("8 - Alterar o Habitat");
                Console.WriteLine("9 - Sair");
                if (erroMenu) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Opção invalida, tente novamente"); Console.ResetColor(); erroMenu = false; }
                Console.Write("\n\nDigite uma opção:");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1://LISTAR HABITATS
                        Logomarca();
                        repAnimal.Listar();
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
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
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
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
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
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
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5://INSERIR UM NOVO ANIMAL
                        Logomarca();
                        Animal animal01 = new Animal();
                        Console.WriteLine("Insira o nome do animal");
                        animal01.Nome = Console.ReadLine();
                        Console.WriteLine("Insira a especie do animal");
                        animal01.Especie = Console.ReadLine();
                        Console.WriteLine("Insira a idade do animal");
                        animal01.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o id do cuidador");
                        animal01.IdFuncionario = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o id do Habitat");
                        animal01.IdHabitat = int.Parse(Console.ReadLine());
                        repAnimal.Inserir(animal01);
                        Console.WriteLine("Criado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6://REMOVER UM ANIMAL
                        Logomarca();
                        int idRemoverAnimal;
                        Console.WriteLine("Digite o Id do animal que deseja remover:");
                        idRemoverAnimal = int.Parse(Console.ReadLine());
                        repHabitat.Remover(idRemoverAnimal);
                        Console.WriteLine("Removido com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 7://ALTERAR O CUIDADOR!
                        Logomarca();
                        int number;
                        int cuidadorId;
                        Console.WriteLine("Digite o Id do animal, que terá a seu cuidador alterado:");
                        number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o id do novo cuidador do animal:");
                        cuidadorId = int.Parse(Console.ReadLine());
                        repAnimal.AlterarCuidador(number, cuidadorId);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 8://ALTERAR O HABITAT!
                        Logomarca();
                        int numero;
                        int idHabitat;
                        Console.WriteLine("Digite o Id do animal, que terá a seu Habitat alterado:");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o id do novo Habitat do animal:");
                        idHabitat = int.Parse(Console.ReadLine());
                        repAnimal.AlterarHabitat(numero, idHabitat);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 9://sair
                        string respostaDoUsuarioMenuAnimal;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuarioMenuAnimal = Console.ReadLine().ToUpper();
                        if (respostaDoUsuarioMenuAnimal == "S") { looping = false; }
                        break;

                    default:
                        erroMenu = true;
                        break;
                }
            } while (looping);


        }

        static public void MenuRecurso()
        {
            bool erroMenu = false;
            bool looping = true;
            do
            {
                Logomarca();
                
                int caseSwitch;
                Console.WriteLine("Seleciona a opção que deseja:");
                Console.WriteLine("1 - Listar os Recursos");
                Console.WriteLine("2 - Alterar o nome do Recurso(id)");
                Console.WriteLine("3 - Alterar a quantidade do Recurso(id)");
                Console.WriteLine("4 - Inserir Recurso");
                Console.WriteLine("5 - Remover");
                Console.WriteLine("6 - Sair");
                if (erroMenu) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Opção invalida, tente novamente"); Console.ResetColor(); erroMenu = false; }
                Console.Write("\n\nDigite uma opção:");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {

                    case 1://LISTAR Recursos
                        Logomarca();
                        repRecurso.Listar();
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 2:// ALTERAR  nomerecursos
                        Logomarca();
                        int idAlterar;
                        string nome;
                        Console.Write("Digite o Id do recurso que deseja alterar o nome:");
                        idAlterar = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do recurso:");
                        nome = Console.ReadLine();
                        repRecurso.AlterarNome(idAlterar, nome);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 3:// ALTERAR  Quantiodade
                        Logomarca();
                        int id;
                        int quantidade;
                        Console.Write("Digite o Id do recurso que deseja alterar a quantidade:");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade do recurso:");
                        quantidade = int.Parse(Console.ReadLine());
                        repRecurso.AlterarQuantidade(id, quantidade);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 4://INSERIR Recurso
                        Logomarca();
                        Recurso rec = new Recurso();
                        Console.WriteLine("Insira o nome do Recurso");
                        rec.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade do produto:");
                        rec.Quantidade = int.Parse(Console.ReadLine());
                        repRecurso.Inserir(rec);
                        Console.WriteLine("Criado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5://Remover Recurso
                        Logomarca();
                        int idRemover;
                        Console.WriteLine("Digite o Id do Recurso que deseja remover:");
                        idRemover = int.Parse(Console.ReadLine());
                        repRecurso.Remover(idRemover);
                        Console.WriteLine("Removido com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6://sair
                        string respostaDoUsuario;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuario = Console.ReadLine().ToUpper();
                        if (respostaDoUsuario == "S") { looping = false; }
                        break;

                    default:
                        erroMenu = true;
                        break;
                }
            } while (looping);

        }

        static public void MenuFuncionario()
        {
            //Codigo que funciona no Mario, FUncioMario, HAHAHAHAHAH
            bool erroMenu = false;
            bool looping = true;
            do
            {
                Logomarca();

                int caseSwitch;
                Console.WriteLine("Seleciona a opção que deseja:");
                Console.WriteLine("1 - Listar os Funcionarios");
                Console.WriteLine("2 - Alterar o nome do Funcionario(id)");
                Console.WriteLine("3 - Alterar o CPF do Funcionario(id)");
                Console.WriteLine("4 - Alterar a idade do Funcionario(id)");
                Console.WriteLine("5 - Inserir um novo Funcionario");
                Console.WriteLine("6 - Remover");
                Console.WriteLine("7 - Sair");
                if (erroMenu) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Opção invalida, tente novamente"); Console.ResetColor(); erroMenu = false; }
                Console.Write("\n\nDigite uma opção:");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {

                    case 1://LISTAR Funcionario
                        Logomarca();
                        repFuncionario.Listar();
                        Console.WriteLine("Pressione qualquer tecla para continuar:");
                        Console.ReadKey();
                        break;

                    case 2:// ALTERAR  Funcionario nome                        
                        int idAlterar;
                        string nome;
                        Console.Write("Digite o Id do Funcionario que deseja alterar o nome:");
                        idAlterar = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do Funcionario:");
                        nome = Console.ReadLine();
                        repFuncionario.AlterarNome(idAlterar, nome);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 3:// ALTERAR  cpf
                        Logomarca();
                        int id;
                        int cpf;
                        Console.Write("Digite o Id do Funcionario que deseja alterar o CPF:");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o novo CPF do funcionario:");
                        cpf = int.Parse(Console.ReadLine());
                        repFuncionario.AlterarCpf(id, cpf);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                        
                    case 4:// ALTERAR  Idade
                        Logomarca();
                        int identificacao;
                        int idade;
                        Console.Write("Digite o Id do Funcionario que deseja alterar a idade:");
                        identificacao = int.Parse(Console.ReadLine());
                        Console.Write("Digite a nova idade do funcionario:");
                        idade = int.Parse(Console.ReadLine());
                        repFuncionario.AlterarIdade(identificacao, idade);
                        Console.WriteLine("Alterado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5://INSERIR Funcionario
                        Logomarca();
                        Funcionario fun = new Funcionario();
                        Console.WriteLine("Insira o nome do Funcionario");
                        fun.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do Funcionario:");
                        fun.Cpf = long.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a idade do Funcionario:");
                        fun.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Cargo do Funcionario:");
                        fun.Cargo = Console.ReadLine();
                        Console.WriteLine("Digite o Setor do Funcionario(nome):");
                        fun.Setor = Console.ReadLine();
                        repFuncionario.Inserir(fun);
                        Console.WriteLine("Criado com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6://Remover Funcionario
                        Logomarca();
                        int idRemover;
                        Console.WriteLine("Digite o Id do Funcionario que deseja remover:");
                        idRemover = int.Parse(Console.ReadLine());
                        repFuncionario.Remover(idRemover);
                        Console.WriteLine("Removido com sucesso\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 7://sair
                        string respostaDoUsuario;
                        Console.WriteLine("Você quer realmente sair?(s/n):");
                        respostaDoUsuario = Console.ReadLine().ToUpper();
                        if (respostaDoUsuario == "S") { looping = false; }
                        break;

                    case 8:
                        
                        Console.WriteLine(cmd.ExecuteScalar());

                        break;

                    default:
                        erroMenu = true;
                        break;
                }
            } while (looping);
        }
    }
}
