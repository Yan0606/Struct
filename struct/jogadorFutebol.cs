namespace Struct;

public struct jogadorFutebol{


    public string nome;
    public string numeroCamisa;
    public string posicao;
    public string registrarNumeroCartoesAmarelos;
    public string registrarNumeroCartoesVermelhos;
    public string verificarVinculoClube;

    public jogadorFutebol(string nome, string numeroCamisa, string posicao, string registrarNumeroCartoesAmarelos, string registrarNumeroCartoesVermelhos, string verificarVinculoClube){
        this.nome = nome;
        this.numeroCamisa = numeroCamisa;
        this.posicao = posicao;
        this.registrarNumeroCartoesAmarelos = registrarNumeroCartoesAmarelos;
        this.registrarNumeroCartoesVermelhos = registrarNumeroCartoesVermelhos;
        this.verificarVinculoClube = verificarVinculoClube;
    }

    public string imprimir(){
        return "\nO jogador: " + this.nome + 
        "\nCamisa numero:" + this.numeroCamisa +
        "\nJoga de:" + this.posicao +
        "\nEle tem:" + this.registrarNumeroCartoesAmarelos + "\tAmarelos" + 
        "\nEle tem :" + this.registrarNumeroCartoesVermelhos + "\tVermelhos" + 
        "\nEle esta no time :" + this.verificarVinculoClube;
    }

}