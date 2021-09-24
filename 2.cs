using System;	

public class Lampada{
    private bool status = false;

    public void ligar(){
            status = true;
        }
	public void desligar(){
            status = false;
        }
        
    public String observar(){
        if (status == true){
            return "Lâmpada Ligada";
        }
        else {
            return "Lâmpada Desligada";
        }
    }

    public static void Main(){

    Lampada teste = new Lampada();
	
	teste.ligar();
		
    Console.WriteLine(teste.observar());

    }
}


