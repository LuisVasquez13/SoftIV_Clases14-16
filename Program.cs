// Programa usando la condicional IF
// Correspondiente a la clase 14 de C#

const int totalDealer = 15; // Constante para dealer
string message = "";

// Se ingresa la cantidad que tiene el jugador
Console.Write("Ingresa la cantidad del jugador: ");
int totalJugador = Convert.ToInt32(Console.ReadLine());


//Juntar 21 pidiendo cartas o en caso de tener menos de 21 tener igual


if (totalJugador > totalDealer && totalJugador <= 21) // Si el jugador es mayor pero igual o menor a 21, gana
{
    message = "Venciste al dealer, felicidades";
}
else if (totalJugador >= 22) // Si el jugador tiene de 22 o mas, pierde
{
    message = "Perdiste ante el dealer, te pasaste de 21";
}
else if (totalJugador <= totalDealer) // Si el jugador tiene la misma cantidad o es menor, pierde
{
    message = "Perdiste ante el dealer, lo siento";
}
else // En el mínimo caso de que el resultado no sea válido
{
    message = "Condición no válida";
}

Console.WriteLine(message); // Se imprime el string del resultado