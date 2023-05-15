namespace Struct;

public struct produto{

    public string Produto;

    public string valor;

    public string PorcentagemCupom;

    public string Quantidade;

   


 public produto (string Produto, string valor, string PorcentagemCupom, string Quantidade){
    this.Produto = Produto;
    this.valor = valor;
    this.PorcentagemCupom = PorcentagemCupom;
    this.Quantidade = Quantidade;
    
 }   



 public string imprimir(){
    return  "\nProduto: " + this.Produto +
    "\nValor: " + this.valor +
    "\nPorcentagem do cupom: " +this.PorcentagemCupom +
    "\nQuantidade: " + this.Quantidade;
 }
}