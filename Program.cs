using System;

namespace Sistema_de_passagens_aereas
{
    class Program
    {
        static void Main(string[] args)
        {
        
          
           //Declarações de variáveis 
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            
            //Arrays Login
            string [] login = new string [1];

            //Dados do Cadastro de Passagens 
            string[] nomes = new string [5]; // dados de cadastro
            string[] origem = new string [5];
            string[] destino= new string [5];
            string[] data = new string [5]; //fim  dados de cadastro

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------Sistema de Passagens---------");
            Console.WriteLine("----------------AULA---------------------");

            do
            {
            Console.WriteLine("Digite o seu usuário: ");
            login[contador] = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();
            senhaValida = EfetuarLogin(senha); 

            }while(!senhaValida);
        //Menu
            do
            {
                Console.WriteLine("Bem-vindx "+login[contador]);
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1- Cadastrar passagem");
                Console.WriteLine("2- Listar passagens");
                Console.WriteLine("3- Sair");
                escolha = int.Parse(Console.ReadLine());
           
                switch(escolha)
                {
                    case 1:
                        //Cadastrar Passagens 
                        Console.WriteLine("Cadastrar Passageiros");
                        do
                        {
                            if(contador < 5){
                            Console.WriteLine($"Digite o nome do {contador+1}º Passageiro: ");
                            nomes[contador] = Console.ReadLine();

                            Console.WriteLine($"Digite a origem do {contador+1}º Passageiro: ");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine($"Digite o destino do {contador+1}º Passageiro: ");
                            destino[contador] = Console.ReadLine();

                            
                            Console.WriteLine($"Digite a data do voo do {contador+1}º Passageiro: ");
                            data[contador] = Console.ReadLine();

                            contador++;
                            }else{
                                Console.WriteLine("Limite Excedido");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar um novo passageiro? s/n");
                            resposta = Console.ReadLine();
                             

                        } while (resposta.ToUpper() == "s");
                        Console.Clear();
                        break;
                    case 2:
                        //Listar Passagens 
                        Console.WriteLine("Listar Passagens ");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro {nomes[i]}, Origem: {origem[i]}, Destino: {destino[i]} e data do voo: {data[i]}");
                        }
                        break;
                    case 3:
                        //Sair
                        Console.WriteLine("Obrigada por viajar conosco");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (escolha !=3);

            bool EfetuarLogin(string senha){

                if(senha == "123456"){
                    return true;
                }else{
                    Console.WriteLine("Senha incorreta!");  
                    return false;
                }
            }

        }
    }
}
