namespace Struct;

public struct equipeEsporte{
    
   public string equipe;

   public string quantJogador;

   public string jogosEquipe;

   public string golsEquipe;

   public string campeonatoVencido;

   public float totalPremiacoes;

    public string anoEstreia;

    public equipeEsporte( string equipe, string quantJogador, string jogosEquipe, string golsEquipe, string campeonatoVencido, float totalPremiacoes, string anoEstreia){
        this.equipe = equipe;
        this.quantJogador = quantJogador;
        this.jogosEquipe = jogosEquipe;
        this.golsEquipe = golsEquipe;
        this.campeonatoVencido = campeonatoVencido;
        this.totalPremiacoes = 0;
        this.anoEstreia = anoEstreia;
    }

    public void valorcampeonato(float atualizarValor) {
        this.totalPremiacoes = this.totalPremiacoes + atualizarValor;
    }

    public string imprimir(){
        return "\nEquipe: " + this.equipe +
        "\nQuantidade de jogadores: " + this.quantJogador + 
        "\nJogos jogados: " + this.jogosEquipe + 
        "\nGols marcados: " + this.golsEquipe +
        "\nCampeonato Vencido: " + this.campeonatoVencido + 
        "\nPremiações: " + this.totalPremiacoes +
        "\nEstreiou: " + this.anoEstreia;

    }


}