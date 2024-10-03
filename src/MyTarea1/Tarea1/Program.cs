using static System.Console;
//2.Buscar cómo se declara una constante en C# 
/*
En C#, una constante se declara con const. El valor de una constante
no debe cambiar porque es inmutable y está definido en tiempo de compilación. 
Intentar cambiarlo da un error de compilación:
*/
const int mayorEdad = 18;

//1.Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor. 
int edadVictor = 22;
string nombre = "Victor";
decimal dineroVictor = 500.55M;
double dineroDevido = 400.23;
bool esMayor;
esMayor = edadVictor > mayorEdad;
if (esMayor)
{
    WriteLine($"Hola {nombre}, ya tienes que buscar trabajo eres mayor de edad " +
        $" veo que tienes en tu cuenta {dineroVictor} y debes {dineroDevido} " +
        $" tienes que esforzarte mas para que tengas mas dinero.\n");

}
else {
    WriteLine("Nothing to say");

}

/*3.Declara un entero, incrementarlo, decrementarlo
 * hacer operaciones con el. */
int entero = 1;
entero++;
entero++;
--entero;
entero = entero + 5 * 2 / 1 - 3;
WriteLine(entero);
WriteLine("\n");

//4.Declarar un float con valor=10152466.25. Declara un byte que es igual a 5 + el float. 
float valorF = 10152166.25f;
byte valorB = 5;
valorF += valorB;
WriteLine(valorF);

WriteLine("\n");

DateTime fechaHoy = DateTime.Now;
WriteLine(fechaHoy);

ReadLine();