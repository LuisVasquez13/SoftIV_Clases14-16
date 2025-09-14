// Programa usando la condicional Switch
// Correspondiente a la clase 14 y 15 de C#

const int totalDealer = 15; // Constante para dealer
string message = "";
string switchControl = "21";
int totalJugador = 21;


//Juntar 21 pidiendo cartas o en caso de tener menos de 21 tener igual

switch (switchControl)
{
    case "menu":
        Console.WriteLine("Welcome al c a s i n o");
        Console.WriteLine("Escriba 21 para jugar al 21:");
        switchControl = Console.ReadLine();
        break;

    case "21":
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
        break;
    default:
        Console.WriteLine("Valor ingresado no válido");
        break;
}