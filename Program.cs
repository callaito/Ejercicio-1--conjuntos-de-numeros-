// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;

Console.WriteLine("Categorizar los numeros");

Console.WriteLine("Cantidad de numeros");
int cantidad = int.Parse(Console.ReadLine());
int numero;

int par_posi =0, par_nega=0, inpar_posi=0, inpar_nega=0;


for (int i = 1; i<= cantidad; i++)

{
    Console.WriteLine("Numero entero " + i);
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero %2 ==0 && numero>0)
    {
        Console.WriteLine("El numero es par positivo");
       
    }

    else if (numero %2 ==0 && numero<0)
    {
        Console.WriteLine("El numero es par negativo");
    }

    else if (numero %2 != 0 && numero>0)
    {

        Console.WriteLine("El numero es impar positivo");
    }
    else
    {
        Console.WriteLine("El numero es impar negativo");
    }

    Console.WriteLine("Cantidad de numero par positivo: " + par_posi);
    Console.WriteLine("Cantidad de numero par negativo: " + par_nega);
    Console.WriteLine("Cantidad de numero inpar positivo: " + inpar_posi);
    Console.WriteLine("Cantidad de numero inpar negativo: " + inpar_nega);
}
    

    