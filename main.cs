using System;
using System.Collections.Generic;

public class Docearia
{
    int doceSelecionado;
    
    public class Pedido{
        public Docearia doce{get;private set;}
        public Pedido(Docearia doce){
            this.doce = doce;
        }
    }
    public void ExibirMenu()
    {
        Console.WriteLine("1- Brigadeiro");
        Console.WriteLine("2- Beijinho");
        Console.WriteLine("3- Cajuzinho");
        Console.WriteLine("4- Bolo de Chocolate");
        Console.WriteLine("5- Bolo de Cenoura");

    }
    public Docearia ObterDocePorNumero(int numeroDoce) {
        Docearia doce = new Docearia();
        return doce;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Docearia doceSelecionado = null;
        Docearia.Pedido pedido = new Docearia.Pedido(doceSelecionado);
        Docearia docearia = new Docearia();


        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Bem vindo a Docearia Yasmim e Maria!!");
         Console.WriteLine("-----------------");
        Console.WriteLine("🧁Menu de doces🧁");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        docearia.ExibirMenu();

        Console.WriteLine("Digite o número referente ao doce que você deseja ou insira 0 para sair");

        int numeroDoce;
        while (!int.TryParse((Console.ReadLine()), out numeroDoce))
        {
            if (numeroDoce == 0)
            {
                break;
            }
            Docearia selectedDoce = docearia.ObterDocePorNumero(numeroDoce);

            if(doceSelecionado!=null){
                Console.WriteLine("Você selecionou{doceSelecionado.Nome}");
                Docearia.Pedido newPedido = new Docearia.Pedido(doceSelecionado);     0
            }
        }


    }
}

