namespace Struct;

public struct professor{

    public string nome;

    public string cpf;

    public string dataNasc;

    public float salario;

    public string endereco;

    

    



    public professor (string nome, string cpf, string dataNasc, float salario, string endereco, float reajuste ){
        this.nome = nome;
        this.cpf=cpf;
        this.dataNasc = dataNasc;
        this.salario = salario;
        this.endereco = endereco;
        
        
    }

        public void reajustar(float taxa){
            float x = (this.salario * taxa)/100;
            this.salario = this.salario + x;
        }


    public string imprimir(){
        return "\nProfessor: " + this.nome + 
        "\nCPF: " + this.cpf + 
        "\nData de Nascimento: " + this.dataNasc +
        "\nSalario: " + this.salario + 
        "\nEndereço: " + this.endereco;
        
    }
}