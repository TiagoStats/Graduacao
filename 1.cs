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
    public void setCanal(int numeroCanal) {
        if (numeroCanal < 257 || numeroCanal > 0){
            canal = numeroCanal;
        } 
    }
    public void aumentaCanal() {
        if (canal < 256){
            canal = canal + 1;
        } 
    }
    public void diminuiCanal() {
        if (canal > 1){
            canal = canal - 1;
        }
    }
    public void aumentaVolume() {
        if (volume < 100){
            volume = volume + 1;
        } 
    }

    public void diminuiVolume() {
        if (volume > 0){
            volume = volume - 1;
        } 
    }

    public static void Main(){

    Televisor teste = new Televisor();
	
	teste.aumentaCanal();
		
    Console.WriteLine(teste.getCanal());

    }
}


