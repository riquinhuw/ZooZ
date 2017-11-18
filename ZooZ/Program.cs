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
     * MÃOS NA OBRÃ, pera quero dizer, DEDOS NO TECLADO!!! 
     * 
    */
    class Program
    {
        static void Main(string[] args)//PODEM MUDAR O PROGRAM PARA TESTAR SUAS APLIACAÇÕES, fiquem tranquilos!
        {
            RepositorioHabitat repHabitat = new RepositorioHabitat();
            RepositorioRecurso repRecurso = new RepositorioRecurso();

            repHabitat.Listar();

            //repHabitat.Alterar(6,"Sala de Informatica");

            //Recurso agua = new Recurso();
            //agua.Nome = "agua";
            //agua.Quantidade = 100;
            //repRecurso.Inserir(agua);


            //Habitat selva = new Habitat();
            //selva.Nome = "selva";
            //selva.RecursoId = 1;
            //repHabitat.Inserir(selva);

        }
    }
}
