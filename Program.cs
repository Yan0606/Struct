using Struct;

namespace ED
{
    class Program
    {


        static void Main(String[] args)
        {
            string escolha;

            Console.WriteLine("Escolha o que quer fazer: ");
            escolha = Console.ReadLine();

            //JOGADOR DE FUTEBOL
            if(escolha == "jogador"){
                jogadorFutebol jogador1 = new jogadorFutebol();

                jogador1.nome = "messi";
                jogador1.numeroCamisa = "30";
                jogador1.posicao = "Ponta direita";
                jogador1.registrarNumeroCartoesAmarelos ="1";
                jogador1.registrarNumeroCartoesVermelhos ="0";
                jogador1.verificarVinculoClube="Paris Saint German";
                System.Console.WriteLine(jogador1.imprimir());

            // CLIENTE
            }
            else if(escolha == "cliente"){
            //struct 
            CLienteS cliente1 = new CLienteS();

            cliente1.nome = "Neymar";
            cliente1.cpf = "111.111.111-11";
            cliente1.dataNascimento = "05/05/1987";
            cliente1.email = "messiIsBetter@ThenCR7.com";

            System.Console.WriteLine(cliente1.imprimir());
            }

            //EQUIPE ESPORTES
            else if(escolha == "equipe"){
                //struct    
                equipeEsporte equipe1 = new equipeEsporte();

                equipe1.equipe ="Real Madrid";
                equipe1.quantJogador="23";
                equipe1.jogosEquipe="56";
                equipe1.golsEquipe="61";
                equipe1.campeonatoVencido="Champions League";
                equipe1.valorcampeonato(1000.0f);
                equipe1.valorcampeonato(5000.0f);
                equipe1.anoEstreia="1902";

                System.Console.WriteLine(equipe1.imprimir());
                
                
            }
            //PRODUTO
             else if(escolha == "produto"){

              produto produto1 = new produto();
              
              produto1.Produto = "Moletom";
              produto1.tamanho = "GG";
              produto1.marca = "Nike";
              produto1.valor = (100);
              produto1.atualizar(10);
              produto1.PorcentagemCupom = "10%";
              produto1.Quantidade = "8";

              Console.WriteLine(produto1.imprimir());
            }

            //PROFESSOR
            else{

                professor professor1 = new professor();

                professor1.nome = "Bruno";
                professor1.cpf = "111.111.111-11";
                professor1.dataNasc = "01/01/1990";
                professor1.salario = (3000);
                professor1.endereco = "Rua: Messi is better then cr7";
                professor1.reajustar(60);
                professor1.faltouPerdeu(2);

                   

                System.Console.WriteLine(professor1.imprimir());                
            }
        }    
    }
}