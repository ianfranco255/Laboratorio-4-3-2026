int cantAlumnos = 0;
int cantComputadoras = 0;
Console.WriteLine("Ingrese la cantidad de computadoras: ");
string? recibido = Console.ReadLine();
Console.WriteLine("Ingrese la cantidad de Alumnos: ");
Console.ReadLine();
if (int.TryParse(recibido, out int num))
{
    cantComputadoras = num;
}
else
{
    Console.WriteLine("ERROR");
}
if (cantAlumnos > cantComputadoras) 
{ 
    Console.WriteLine("Faltan computadoras para la sala de alumnos."); 
}
else
    {
    Console.WriteLine("Hay suficientes computadoras en la sala");
    }
