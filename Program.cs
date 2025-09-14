// Programa usando la condicional IF, el menu Switch y el ciclo While
// Correspondiente a la clase 14, 15 y 16 de C#

System.Random random = new System.Random();

int totalJugador = 0;
int totalDealer = 15;
int num = 0;
string message = "";
bool bucleMenu = true;
int menuOpcion;
string continuarCartas = "no";

// Bucle while que se repite hasta que la variable sea igual a false
while (bucleMenu == true)
{
    // String que contiene las opciones del menu
    String menu = """
        Menú de juego:
        1. Jugar
        2. Salir
        """;
    Console.WriteLine(menu);

    // Se puede ingresar 1 o 2 para entrar en los dos casos: jugar o salir
    Console.Write("\nIngrese su opción: ");
    menuOpcion = Convert.ToInt32(Console.ReadLine());

    switch (menuOpcion) // Casos del switch
    {
        case 1: //Si se elige jugar
            totalJugador = 0; // Se inializa cada vez en cero
            do
            {
                num = random.Next(1, 12); // Numero random para cada lanzamiento
                totalJugador = totalJugador + num;

                Console.WriteLine("\nTomando tu carta...");
                Console.WriteLine($"Te salio el número: {num}"); // Se muestra lo que salio
                Console.WriteLine("Deseas otra carta?");
                continuarCartas = Console.ReadLine();
                // Dependiendo de si es "si", se continua sacando mas
            } while (continuarCartas == "Si" || continuarCartas == "si");

            // Muestra la cantidad del jugador
            Console.WriteLine($"\nTu cantidad: {totalJugador}");


            // Condicionales IF
            // Reglapar ganar : Juntar mas de 15 cartas y menos de 22

            // Si el jugador es mayor pero igual o menor a 21, gana
            if (totalJugador > totalDealer && totalJugador <= 21) {
                message = "Venciste al dealer, felicidades";
            }
            // Si el jugador tiene de 22 o mas, pierde
            else if (totalJugador >= 22) {
                message = "Perdiste ante el dealer, te pasaste de 21";
            }
            // Si el jugador tiene la misma cantidad o es menor, pierde
            else if (totalJugador <= totalDealer) {
                message = "Perdiste ante el dealer, lo siento";
            }
            // En el mínimo caso de que el resultado no sea válido
            else {
                message = "Condición no válida";
            }

            // Se imprime el string del resultado
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
            break;

        case 2: // Si se selecciona "Salir", se sale del bucle y del programa
            bucleMenu = false;
            break;

        default: // Valor invalido
            Console.WriteLine("Valor ingresado no válido");
            break;
    }
}