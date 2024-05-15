using System.Formats.Asn1;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("PRÁCTICA DE LABORATORIO");
        Console.WriteLine("Ingresar el valor del radio");
        double radio = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("");

        Circulo objcirculo =new Circulo (radio);

        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        objcirculo.CalcularGeometria(ref perimetro, ref area,ref volumen);
        Console.WriteLine("Los valores calculados son iagual a:");
        Console.WriteLine($"El perimetro es igual a:{perimetro}");
        Console.WriteLine($"El área es igual a:{area}");
        Console.WriteLine($"El volumen es igual a:{volumen}");

    }
}