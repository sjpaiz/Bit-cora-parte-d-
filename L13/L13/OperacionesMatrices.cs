using System.Data;
using Microsoft.VisualBasic;

class OperacionesMatrices
{

    public int[,] matriz = new int[0,0];

    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {
        int cantidadFilas = 0;
        int cantidadCols = 0;

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine());

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine());
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

       public void ImprimirMatriz(int [,] a)
    {
        

       for(int i=0; i< a.GetLength(0); i++)
       {
        Console.WriteLine("");
        for(int j=0; j < a.GetLength(1); j++)
        {

               Console.Write(a[i,j]+"\t"); 

        }
       }
    }

     public void BuscarNumero (int numero)
    {
        for (int i=0; i <matriz.GetLength(0); i++)
        {
            for (int j=0; j <matriz.GetLength(1); j++)
            {
                if (matriz[i,j] == numero)
                {
                    Console.WriteLine(i+"\t"+j+"\t");
                }    
            }

        }
    }

     public void numeroPar ()
    {
        for (int i=0; i <matriz.GetLength(0); i++)
        {
            for (int j=0; j <matriz.GetLength(1); j++)
            {
                int par = matriz[i,j] % 2;
                if(par == 0)
                {
                    Console.Write(matriz[i,j]+"\t");
                }
            }
            
        }
        Console.WriteLine("");
       }
}