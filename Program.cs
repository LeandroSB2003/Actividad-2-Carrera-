using actividad;



class Circuito
{

static void Main(string[] args){

int tc = 0;
int con = 0;
int tcC = 0;
int conC = 0;
int ConNV = 0;
int TiemM = 0;
int TiemF = 0;
int TiemR = 0;
string PistNM = null;
string PistNF = null;
string PistNR = null;

Redbull redbull = new Redbull();
Ferrari ferrari = new Ferrari();
Mclaren mclaren = new Mclaren();

while (true)
{

Console.WriteLine("Selecciona");
Console.WriteLine("1. Agregar Monoplaza\n"
                +"2. Sacar Monoplaza\n"
                +"3. Realizar prueba\n"
                +"4. Salir");
tc = Int32.Parse(Console.ReadLine());

if(tc == 1)
{

    if(con != 1)
    {

        Console.WriteLine("Selecciona que Monoplaza agregaras: ");
        Console.WriteLine("1. Mclare\n" 
                         + "2. Ferrari\n"
                         + "3. Redbull");
        tcC = Int32.Parse(Console.ReadLine());
        if(tcC == 1)
        {
            con=1;
            conC=1;

        }

        if(tcC == 2)
        {
            con=1;
            conC=2;

        }

        if(tcC == 3)
        {
            con=1;
            conC=3;

        }if(tcC >= 4)
        {

            Console.WriteLine("Selecciona solo valores permitidos");

        }

}else
{

    Console.WriteLine("Ya hay un Monoplaza en el circuito");

}

}
    
if(tc == 2)
{

if(con == 1)
    {

        if(conC == 1)
        {
            Console.WriteLine("Acabas de sacar el MClaren de la pista");
            conC=0;
            con=0;

        }

        if(conC == 2)
        {
            Console.WriteLine("Acabas de sacar el Ferrari de la pista");
            conC=0;
            con=0;

        }

        if(conC == 3)
        {
            Console.WriteLine("Acabas de sacar el Redbull de la pista");
            conC=0;
            con=0;

        }


        }else
        {

            Console.WriteLine("No hay ningun Monoplaza en la pista");

        }

}

if(tc == 3)
{

if(con == 1)
{

    if(conC == 1){
        

        Console.WriteLine("Selecciona la cantidad de vueltas que el Mclaren dara");
        ConNV = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el nombre de la pista en la que participara");
        PistNM= Console.ReadLine();

        Console.WriteLine("El Mclaren se encuentra apagado");
        mclaren.Apagar=1;

        if(mclaren.Apagar==1)
        {

        mclaren.Apagar=0;
        mclaren.Escender=1;
        mclaren.Movimiento=1;

        Console.WriteLine("El Mclaren se prendio");

        }     


        if(mclaren.Escender==1 && mclaren.Movimiento==1)
        {


        mclaren.Detener=1;

        Console.WriteLine("El Mclaren se encuentra detenido"); 

        }


        if(mclaren.Escender==1 && mclaren.Detener==1)
        {

        

        mclaren.Detener=0;   

        Console.WriteLine("El Mclaren se encuentra ahora en movimiento");

        }

        if(mclaren.Escender==1 && mclaren.Movimiento==1)
        {


        mclaren.Detener=1;

        Console.WriteLine("El Mclaren culmino asi que se detuvo"); 

        }

        if(mclaren.Escender==1 && mclaren.Detener==1)
        {

        mclaren.Apagar=1;

        Console.WriteLine("El Mclaren se apago"); 

        }

        Console.WriteLine("La cantidad de " + ConNV + " vueltas las dio en " + mclaren.Tiempo() + " minutos, en la pista " + PistNM);

        }

        TiemM = mclaren.Tiempo();


        if(conC == 2)
        {
            


        Console.WriteLine("Selecciona la cantidad de vueltas que el Ferrari dara");
        ConNV = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el nombre de la pista en la que participara");
        PistNF= Console.ReadLine();

        Console.WriteLine("El Ferrari se encuentra apagado");
        ferrari.Apagar=1;

        if(ferrari.Apagar==1)
        {

        ferrari.Apagar=0;
        ferrari.Escender=1;
        ferrari.Movimiento=1;

        Console.WriteLine("El Ferrari se prendio");

        }     


        if(ferrari.Escender==1 && ferrari.Movimiento==1)
        {


        ferrari.Detener=1;

        Console.WriteLine("El Ferrari se encuentra detenido"); 

        }


        if(ferrari.Escender==1 && ferrari.Detener==1)
        {

        

        ferrari.Detener=0;   

        Console.WriteLine("El Ferrari se encuentra ahora en movimiento");

        }

        if(ferrari.Escender==1 && ferrari.Movimiento==1)
        {


        ferrari.Detener=1;

        Console.WriteLine("El Ferrari culmino asi que se detuvo"); 

        }

        if(ferrari.Escender==1 && ferrari.Detener==1)
        {

        ferrari.Apagar=1;

        Console.WriteLine("El Ferrari se apago"); 

        }



        Console.WriteLine("La cantidad de " + ConNV + " vueltas las dio en " + ferrari.Tiempo() + " minutos, en la pista " + PistNF);

        TiemF=ferrari.Tiempo();

        }
    

        if(conC == 3)
        {


        Console.WriteLine("Selecciona la cantidad de vueltas que el redbull dara");
        ConNV = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el nombre de la pista en la que participara");
        PistNR= Console.ReadLine();

        Console.WriteLine("El redbull se encuentra apagado");
        redbull.Apagar=1;

        if(redbull.Apagar==1)
        {

        redbull.Apagar=0;
        redbull.Escender=1;
        redbull.Movimiento=1;

        Console.WriteLine("El redbull se prendio");

        }     


        if(redbull.Escender==1 && redbull.Movimiento==1)
        {


        redbull.Detener=1;

        Console.WriteLine("El redbull se encuentra detenido"); 

        }


        if(redbull.Escender==1 && redbull.Detener==1)
        {

        

        redbull.Detener=0;   

        Console.WriteLine("El redbull se encuentra ahora en movimiento");

        }

        if(redbull.Escender==1 && redbull.Movimiento==1)
        {


        redbull.Detener=1;

        Console.WriteLine("El redbull culmino asi que se detuvo"); 

        }

        if(redbull.Escender==1 && redbull.Detener==1)
        {

        redbull.Apagar=1;

        Console.WriteLine("El redbull se apago"); 

        }

        Console.WriteLine("La cantidad de " + ConNV + " vueltas las dio en " + redbull.Tiempo() + " minutos, en la pista " + PistNR);
        TiemR=redbull.Tiempo();


        }if(conC >= 4)
        {

            Console.WriteLine("No se tiene ningun vehiculo seleccionado");

        }

}
}

if(tc >= 4)
{

Console.WriteLine("Lista de clasificacion: \n"
                + "El Mclaren hizo " + TiemM + " minutos, en la pista " + PistNM + "\n"
                + "El Ferrari hizo " + TiemF + " minutos, en la pista " + PistNF + "\n"
                + "El Redbull hizo " + + TiemR + " minutos, en la pista " + PistNR + "\n");

break;

}

}
}
}





