namespace Struct;

public struct CLienteS{
    public string nome;

    public string cpf;

    public string dataNascimento;

    public string email;

    public CLienteS(string nome, string cpf, string dataNascimento, string email){

 this.nome = nome;
 this.cpf = cpf;
 this.dataNascimento = dataNascimento;
 this.email = email;

  }

  public string imprimir(){
    return "\nNome: " + this.nome + 
    "\nCpf: " + this.cpf +
    "\nData de Nascimento: " + this.dataNascimento + 
    "\nE-mail: " + this.email;
  }

}