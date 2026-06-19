using System;

class ConsoleApp5
{
    static void CargarNave(int[,,] nave, int ala, int componente, int sector, int cantidad)
    {
        nave[ala, componente, sector] += cantidad;
    }

    static void MostrarNave(int[,,] nave, int numeroJugador)
    {
        Console.WriteLine($"\n--- ESTADO DE LA NAVE JUGADOR {numeroJugador} ---");
        string[] alas = { "Izquierda", "Derecha" };
        string[] componentes = { "Mando", "Motores", "Armamento" };

        for (int a = 0; a < 2; a++)
        {
            for (int c = 0; c < 3; c++)
            {
                for (int s = 0; s < 4; s++)
                {
                    if (nave[a, c, s] > 0)
                    {
                        Console.WriteLine($"Ala {alas[a]} -> Cápsula {componentes[c]} -> Sector {s + 1}: {nave[a, c, s]} tripulantes.");
                    }
                }
            }
        }
        Console.WriteLine("-------------------------------------------\n");
    }

    static void Main()
    {
        int[,,] nave1 = new int[2, 3, 4];
        int[,,] nave2 = new int[2, 3, 4];

        Console.WriteLine("La guerra galáctica ha comenzado. Dos comandantes se enfrentan en un sector del espacio.\nEl objetivo es eliminar a la tripulación enemiga antes de que ellos eliminen la tuya.\n\n");

        // Bucle para iterar entre los 2 jugadores de forma secuencial
        for (int j = 0; j < 2; j++)
        {
            // Seleccionamos dinámicamente qué matriz usar según el turno del jugador
            int[,,] naveActual = (j == 0) ? nave1 : nave2;
            int tripulantes = 20;

            Console.WriteLine($"TURNO DEL JUGADOR {j + 1}");

            // El jugador distribuye tripulantes hasta que se quede sin ninguno (0)
            while (tripulantes > 0)
            {
                Console.WriteLine($"Tienes {tripulantes} tripulantes disponibles para asignar.");

                // 1. SELECCIÓN DE ALA
                int indiceAla = -1;
                while (indiceAla == -1)
                {
                    Console.Write("Seleccione Ala: Izq, Der: ");
                    string? entradaAla = Console.ReadLine();
                    if (entradaAla == "1" || entradaAla?.ToLower() == "izq") indiceAla = 0;
                    else if (entradaAla == "2" || entradaAla?.ToLower() == "der") indiceAla = 1;
                    else Console.WriteLine("ERROR: Selección de ala inválida.");
                }

                // 2. SELECCIÓN DE COMPONENTE / CÁPSULA
                int indiceComponente = -1;
                while (indiceComponente == -1)
                {
                    Console.Write("Seleccione cápsula: Mando, Motores, Armamento: ");
                    string? entradaCap = Console.ReadLine();
                    if (entradaCap == "1") indiceComponente = 0;
                    else if (entradaCap == "2") indiceComponente = 1;
                    else if (entradaCap == "3") indiceComponente = 2;
                    else Console.WriteLine("ERROR: Selección de cápsula inválida.");
                }

                // 3. SELECCIÓN DE SECTOR / HABITACIÓN
                int indiceSector = -1;
                while (indiceSector == -1)
                {
                    Console.Write("Seleccione sector/habitación: Sector 1, Sector 2, Sector 3, Sector 4: ");
                    string? entradaSector = Console.ReadLine();
                    if (int.TryParse(entradaSector, out int sectorElegido) && sectorElegido >= 1 && sectorElegido <= 4)
                    {
                        indiceSector = sectorElegido - 1; // Ajustamos a índice base 0 (0 a 3)
                    }
                    else Console.WriteLine("ERROR: Selección de sector inválida.");
                }

                // 4. INGRESO Y VALIDACIÓN DE TRIPULANTES
                int cantidadTripulantes = 0;
                while (true)
                {
                    Console.Write($"¿Cuántos tripulantes ingresará en esta zona? (Disponibles: {tripulantes}): ");
                    string? entradaTrip = Console.ReadLine();

                    if (int.TryParse(entradaTrip, out cantidadTripulantes))
                    {
                        if (cantidadTripulantes >= 0 && cantidadTripulantes <= tripulantes)
                        {
                            tripulantes -= cantidadTripulantes;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: Cantidad inválida. Debe ser entre 0 y {tripulantes}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Ingrese un número entero válido.");
                    }
                }

                // 5. CARGAR DIRECTAMENTE EN EL ARRAY TRIDIMENSIONAL
                CargarNave(naveActual, indiceAla, indiceComponente, indiceSector, cantidadTripulantes);
                Console.WriteLine("\n-> Datos guardados correctamente en la nave.\n");
            }

            // Al terminar el bucle de tripulantes, mostramos el resumen de la nave cargada
            MostrarNave(naveActual, j + 1);
            Console.WriteLine("Presiona una tecla para continuar al siguiente turno...");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("¡Ambas naves han sido cargadas exitosamente! Comienza la fase de batalla.");
        // Aquí continúa tu lógica de juego/ataque...
    }
}
