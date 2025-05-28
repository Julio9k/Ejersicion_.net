double numero1;
double numero2;
double resultado;

Console.WriteLine("Ingrese el primer número:");
string? entrada1 = Console.ReadLine();

if (!double.TryParse(entrada1, out numero1))
{
    Console.WriteLine("Entrada inválida para el primer número. Por favor, ingrese un número válido.");
    return;
}

Console.WriteLine("Ingrese el segundo número:");
string? entrada2 = Console.ReadLine();

if (!double.TryParse(entrada2, out numero2))
{
    Console.WriteLine("Entrada inválida para el segundo número. Por favor, ingrese un número válido.");
    return;
}

resultado = Add(numero1, numero2);

Console.WriteLine($"El resultado de la suma de {numero1} y {numero2} es: {resultado}");
  



double Add(double num1, double num2)
{
    return num1 + num2;
}