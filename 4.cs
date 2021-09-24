using System;	

public class Artigo{
    private String titulo;

    public String getTitulo(){
            return titulo;
        }
	public void setTitulo(String tituloDesejado){
            titulo = tituloDesejado;
        }
	
public class Edicao{
	
     private int numero;
	 private int volume;
	 private DateTime data;
	 private int tiragem;

    public int getNumero(){
            return numero;
        }
	
	public int getVolumeo(){
            return volume;
        }
	
	public int getTiragem(){
            return tiragem;
        }
	
	public DateTime getData(){
            return data;
        }
	
	public void setTiragem(int tiragemDesejada){
            tiragem = tiragemDesejada;
        }
	
	public void setNumero(int numeroDesejado){
            numero = numeroDesejado;
        }
	
	public void setData(DateTime dataDesejada){
            data = dataDesejada;
        }
	
	public void setVolume(int volumeDesejado){
            volume = volumeDesejado;
        }
	
public class RevistaCientifica{
	
    private String titulo;
	private int isbn;
	private String periodicidade;

    public String getTitulo(){
            return titulo;
        }
	
	public int getIsbn(){
            return isbn;
        }
	
	public String getPeriodicidade(){
            return periodicidade;
        }
	
	public void setTitulo(String tituloDesejado){
            titulo = tituloDesejado;
        }
	
	public void setIsbn(int isbnDesejado){
            isbn = isbnDesejado;
        }
	
	public void setPeriodicidade(String periodicidadeDesejada){
            titulo = periodicidadeDesejada;
        }
   

    public static void Main(){

    }



