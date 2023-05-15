namespace Struct;

public struct produto{

    public string Produto;

    public string tamanho;

    public string marca;

    public float valor;

    public string PorcentagemCupom;

    public string Quantidade;

   


 public produto (string Produto, string tamanho,string marca,  float valor, string PorcentagemCupom, string Quantidade){
    this.Produto = Produto;
    this.tamanho = tamanho;
    this.marca = marca;
    this.valor = valor;
    this.PorcentagemCupom = PorcentagemCupom;
    this.Quantidade = Quantidade;
    
 }   

public void atualizar(float taxa){
    float x=(this.valor * taxa)/100;
    this.valor = this.valor - x;
} 

 public string imprimir(){
    return  "\nProduto: " + this.Produto +
    "\nTamanho: " + this.tamanho +
    "\nMarca: " + this.marca +
    "\nValor: " + this.valor +
    "\nPorcentagem do cupom: " +this.PorcentagemCupom +
    "\nQuantidade: " + this.Quantidade;
 }
}