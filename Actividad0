int cantComps = 0; //VP
int cantAlumn = 0; //VP
string input; // para readline
bool exitosaConv; // para tryParse



Console.WriteLine("Ingrese la cantidad de alumnos: ");
input = Console.ReadLine(); // se ingresa cant alum
exitosaConv = int.TryParse(input, out int numero); // se verifica si el dato es int | devuelve bool e int | int numero para ingresar a VP

while (exitosaConv == false|| numero < 0)  // <- Mientras conversión exitosa sea falso o numero menor a 0 hacer:
{
    Console.WriteLine("Intente nuevamente...");
    input = Console.ReadLine(); 
    exitosaConv = int.TryParse(input, out numero);
}

cantAlumn = numero; 

Console.WriteLine("Ingrese la cantidad de computadoras: ");
input = Console.ReadLine();
exitosaConv = int.TryParse(input, out numero);


while (exitosaConv == false || numero < 0)  // <- Mientras conversión exitosa sea falso o numero menor a 0 hacer:
{
    Console.WriteLine("Intente nuevamente...");
    input = Console.ReadLine();
    exitosaConv = int.TryParse(input, out numero);
}
cantComps = numero;

Console.WriteLine(cantAlumn);
Console.WriteLine(cantComps);


double promedio = (double)cantComps/ cantAlumn;
Console.WriteLine($"Promedio : {promedio:F3}");

if (cantAlumn <= cantComps)
{
    Console.WriteLine("Equipos suficientes");
}

else
{
    Console.WriteLine("Faltan equipos");
}
