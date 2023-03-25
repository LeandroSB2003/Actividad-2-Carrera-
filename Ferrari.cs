namespace actividad;



public class Ferrari : IMonoplaza
{
    
    public int Escender {get;set;}
    public int Apagar {get;set;}
    public int Detener {get;set;}
    public int Movimiento {get;set;}
    public int Escuderia {get;set;}

    public int Tiempo()
    {
        Random Aleato = new Random();
        return Aleato.Next(100000, 1000000);

    }

}