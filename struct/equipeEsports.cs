namespace Struct;

public struct equipeEsporte{
    
    public string equipe;

    public string registrarCampeonatoVencido;

    public string atualizarValorTotalPremiacoes;

    public string verificarAnoEstreia;

    // public float valor = 0;

    // public void adicionarValor(float novoValor) {
    //     this.valor = this.valor + novoValor;
    // }

    public equipeEsporte(string equipe, string registrarCampeonatoVencido, string atualizarValorTotalPremiacoes, string verificarAnoEstreia){
        this.equipe = equipe;
         this.registrarCampeonatoVencido=registrarCampeonatoVencido;
         this.atualizarValorTotalPremiacoes =atualizarValorTotalPremiacoes;
         this.verificarAnoEstreia=verificarAnoEstreia;
        
     }

     public string imprimir(){
        return "\nEquipe:" + this.equipe + 
        "\nCampeonatos vencidos:" + this.registrarCampeonatoVencido +
        "\nValor da premiação: " +
        this.atualizarValorTotalPremiacoes +
        "\nestreiou em: " + this.verificarAnoEstreia;
     }



}