class Circulo
{
    public double radio;
    

 public Circulo (double radio)
 {
    this.radio = radio;
 }

 private double obtenerperimetro ()
 {
      double perimetro = 2*3.1416 * radio;
      return perimetro;
 }

 private double obtenerarea ()
 {
   double area = 3.1416 * radio*radio;
   return area;
 }
 private double obtenervolumen()
 {
   double volumen = 4 *3.1416* radio*radio*radio /3;
   return volumen;
 }

public void CalcularGeometria(ref double perimetro, ref double area, ref double volumen)
{
  perimetro = obtenerperimetro();
  area = obtenerarea();
  volumen = obtenervolumen();
}
 
}