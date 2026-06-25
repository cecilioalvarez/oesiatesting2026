string[] lineas = File.ReadAllLines("datosalumnos.txt");

foreach (string linea in lineas)
{
    Console.WriteLine(linea);
}
