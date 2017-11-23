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
    {
        static void Main(string[] args)//PODEM MUDAR O PROGRAM PARA TESTAR SUAS APLIACAÇÕES, fiquem tranquilos!
        {
            int caseSwitch;


            RepositorioHabitat repHabitat = new RepositorioHabitat();
            RepositorioRecurso repRecurso = new RepositorioRecurso();
            RepositorioAnimal repAnimal = new RepositorioAnimal();
            RepositorioFuncionario repFuncionario = new RepositorioFuncionario();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ________   ___ _____");
            Console.WriteLine(@"|__  / _ \ / _ \__  /");
            Console.WriteLine(@"  / / | | | | | |/ / ");
            Console.WriteLine(@" / /| |_| | |_| / /_ ");
            Console.WriteLine(@"/____\___/ \___/____|");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.WriteLine("Seleciona a opção que deseja:");
            Console.WriteLine("Opção 1");
            Console.WriteLine("Opção 2");
            Console.WriteLine("Opção 3");
            Console.WriteLine("Opção 4");
            Console.WriteLine("Opção 5");
            caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    repHabitat.Listar();
                    break;

                case 2:
                    int idAlterar;
                    string nome;
                    Console.WriteLine("Digite o Id do Habitat:");
                    idAlterar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do Habitat:");
                    nome = Console.ReadLine();
                    repHabitat.Alterar(idAlterar, nome);                    
                    break;

                case 3:

                    string nomeHabitat;
                    int idRecurso;
                    Console.WriteLine("Insira o nome do Habitat");
                    nomeHabitat = Console.ReadLine();
                    Console.WriteLine("Digite o id do recurso que você deseja inserir:");
                    idRecurso = int.Parse(Console.ReadLine());
                    Habitat h1 = new Habitat(nomeHabitat, idRecurso);
                    repHabitat.Inserir(h1);
                    break;


                case 4:
                    int idRemover;
                    Console.WriteLine("Digite o Id do Habitat que deseja remover:");
                    idRemover = int.Parse(Console.ReadLine());                        
                    repHabitat.Remover(idRemover);
                    break;

                






















            }           
         
        }
    }
}
