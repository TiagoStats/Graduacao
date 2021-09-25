using System;

public class CadastroFuncionario{
 
    private int numeroCTPS;
    private int serieCTPS;

    public int getNumeroCTPS(){
        return numeroCTPS;
    } 
    public int getSerieCTPS(){
        return serieCTPS;
    } 
	public bool setSerieCTPS(int novaSerieCTPS){
		serieCTPS = novaSerieCTPS;
        return true;
    }
	public bool setNumeroCTPS(int novoNumeroCTPS){
		numeroCTPS = novoNumeroCTPS;
        return true;
    }
}
public class CadastroCliente{
 
    private String celular;
    private String rg;
    private String cpf;


    public String getCelular(){
        return celular;
    } 
    public String getRg(){
        return rg;
    }
	public String getCpf(){
        return cpf;
    } 
	public bool setCelular(String novoCelular){
		celular = novoCelular;
        return true;
    }
	public bool setRg(String novoRg){
		rg = novoRg;
        return true;
    }
	public bool setCpf(String novoCpf){
		cpf = novoCpf;
        return true;
    } 
}
public class CadastroFotnecedor{
 
    private String razaoSocial;
    private String inscricaoEstadual;
    private String cnpj;


    public String getRazaoSocial(){
        return razaoSocial;
    } 
    public String getCnpj(){
        return cnpj;
    }
	public String getInscricaoEstadual(){
        return inscricaoEstadual;
    } 
	public bool setRazaoSocial(String novaRazaoSocial){
		razaoSocial = novaRazaoSocial;
        return true;
    }
	public bool setInscricaoEstadual(String novaInscricaoEstadual){
		inscricaoEstadual = novaInscricaoEstadual;
        return true;
    }
	public bool setCnpj(String novoCnpj){
		cnpj = novoCnpj;
        return true;
    } 
}
public class CadastroBasico{
 
    private String nome;
    private String telefone;
    private String email;
	private int codigo;


    public String getNome(){
        return nome;
    } 
    public String getTelefone(){
        return telefone;
    }
	public String getEmail(){
        return email;
    } 
	public int getCodigo(){
        return codigo;
    } 
	public bool setNome(String novoNome){
		nome = novoNome;
        return true;
    }
	public bool setTelefone(String novoTelefone){
		telefone = novoTelefone;
        return true;
    }
	public bool setEmail(String novoEmail){
		email = novoEmail;
        return true;
    } 
	public bool setCodigo(int novoCodigo){
		codigo = novoCodigo;
        return true;
    } 
}



