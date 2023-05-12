using Struct;

namespace EXEMPLO
{
    class Program
    {


        static void Main(String[] args)
        {
            string escolha;

            Console.WriteLine("Escolha o que quer fazer: ");
            escolha = Console.ReadLine();
            
            if(escolha == "jogador"){
                jogadorFutebol jogador1 = new();

                jogador1.nome = "messi";
                jogador1.numeroCamisa = "30";
                jogador1.posicao = "Ponta direita";
                jogador1.registrarNumeroCartoesAmarelos ="1";
                jogador1.registrarNumeroCartoesVermelhos ="0";
                jogador1.verificarVinculoClube="Paris Saint German";
                System.Console.WriteLine(jogador1.imprimir());
            }
            else{
            //struct 
            CLienteS cliente1 = new();

            cliente1.nome = "Neymar";
            cliente1.cpf = "111.111.111-11";
            cliente1.dataNascimento = "05/05/1987";
            cliente1.email = "messiIsBetter@ThenCR7.com";

            System.Console.WriteLine(cliente1.imprimir());
            }


        }

        
           
        
    }
}