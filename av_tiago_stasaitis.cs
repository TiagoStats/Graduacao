using System;	

public class Televisor{
    private bool ligado = false;
    private int canal = 0;
    private int volume = 0;

    public void ligarDesligarTelevisor(){
        if (ligado == true){
            ligado = false;
        }
        else {
            ligado = true;
        }
    } 
    public bool isTelevisorLigado(){
        if (ligado == true){
            return true;
        }
        else {
            return false;
        }
    }
    public int getCanal() {
        return canal;
    }
    public int getVolume() {
        return volume;
    }
    public string setCanal(int numeroCanal) {
        if (canal > 256 || canal < 1){
            return "Canal Inválido";
        } 
        else {
            canal = numeroCanal;
            return "Canal  alterado com sucesso!";
        }
    }
    public string aumentaCanal() {
        if (canal == 256){
            return "Canal Inválido";
        } 
        else {
            canal = canal + 1;
            return "Canal  alterado com sucesso!";
        }
    }
    public string diminuiCanal() {
        if (canal == 1){
            return "Canal Inválido";
        } 
        else {
            canal = canal - 1;
            return "Canal  alterado com sucesso!";
        }
    }
    public string aumentaVolume() {
        if (volume == 100){
            return "Volume no máximo!";
        } 
        else {
            volume = volume + 1;
            return "Volume alterado com sucesso!";
        }
    }

    public string diminuiVolume() {
        if (volume == 1){
            return "Mudo";
        } 
        else {
            volume = volume - 1;
            return "Volume alterado com sucesso!";
        }
    }

    public static void Main(){

    Televisor teste = new Televisor();
	
	teste.aumentaCanal();
		
    Console.WriteLine(teste.getCanal());

    }
}


