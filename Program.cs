// See https://aka.ms/new-console-template for more information

int dia;

Console.WriteLine("Por favor, ingrese un nùmero del 1 al 7");
dia = Convert.ToInt32(Console.ReadLine());

if (dia == 1)
{
    Console.WriteLine("Lunes");
}
else if (dia == 2)
{
    Console.WriteLine("martes");
}
else if (dia == 3)
{
    Console.WriteLine("mièrcoles");
}
else if (dia == 4)
{
    Console.WriteLine("jueves");
}
else if (dia == 5)
{
    Console.WriteLine("viernes");
}
else if (dia == 6)
{
    Console.WriteLine("sàbado");
}
else if (dia == 7)
{
    Console.WriteLine("domingo");
}
else
{
    Console.WriteLine("Error, por favor ingrese un nùmero entre 1 a 7");
}