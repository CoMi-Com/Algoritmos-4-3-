using System;
class consoleApp5
{
    static void Main()
    {
        int[,,] nave1 = new int[2, 3, 4];
        int[,,] nave2 = new int[2, 3, 4];
        int tripulantes = 20;
        int izq = 0;
        int der = 0;
        int mando = 0;
        int motor = 0;
        int armamento = 0;
        int sector1 = 0;
        int sector2 = 0;
        int sector3 = 0;
        int sector4 = 0;

        Console.WriteLine("La guerra galáctica ha comenzado. Dos comandantes se enfrentan en un sector del espacio.\n El objetivo es eliminar a la tripulación enemiga antes de que ellos eliminen la tuya.\n\n");
        //Console.ForegroundColor = ConsoleColor.Green;
        for (int a = 0; a < 2; a++)
        {
            Console.WriteLine($"Jugador {a+1}\n");
            Console.WriteLine($"Seleccione Ala:  [Izq] [Der]\n\n");
            string? alas = Console.ReadLine();
            Console.WriteLine("En qué zona del ala?  Cápsulas[1] o Habitaciones[2]\n\n");
            string? zonas = Console.ReadLine();
            
            while (true)
            {
                if(alas == "Izq" || alas == "izq")
                {  
                    if(zonas == "1")
                    {
                        while (true)
                        {
                            Console.WriteLine("En que cápsula?   Mando[1], Motores[2], Armamento[3]");
                            string? cap = Console.ReadLine();
                            if (cap == "1")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            mando = mando + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if(numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (cap == "2")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            motor = motor + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (cap == "3")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            armamento = armamento + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Ingrese un número entero.");
                                cap = Console.ReadLine();
                            }
                        }
                        break;
                    }
                    else if(zonas == "2")
                    {
                        while (true)
                        {
                            Console.WriteLine("En que sector?   [1], [2], [3], [4]");
                            string? sec = Console.ReadLine();
                            if (sec == "1")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector1 = sector1 + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (sec == "2")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector2 = sector2 + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (sec == "3")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector3 = sector3 + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (sec == "4")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector4 = sector4 + numero;
                                            tripulantes = tripulantes - numero;
                                            izq = izq + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Ingrese un número entero.");
                                sec = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El dato ingresado es incorrecto o no existe.");
                        Console.WriteLine("Solo hay 2 zonas:    [1] o [2]");
                        zonas = Console.ReadLine();
                    }
                    break;
                }
                else if(alas == "Der" || alas == "der")
                {
                    if (zonas == "1")
                    {
                        while (true)
                        {
                            Console.WriteLine("En que cápsula?   Mando[1], Motores[2], Armamento[3]");
                            string? cap = Console.ReadLine();
                            if (cap == "1")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            mando = mando + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (cap == "2")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            motor = motor + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (cap == "3")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            armamento = armamento + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Ingrese un número entero.");
                                cap = Console.ReadLine();
                            }
                        }
                        break;
                    }
                    else if (zonas == "2")
                    {
                        while (true)
                        {
                            Console.WriteLine("En que sector?   [1], [2], [3], [4]");
                            string? sec = Console.ReadLine();
                            if (sec == "1")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector1 = sector1 + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (sec == "2")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector2 = sector2 + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (sec == "3")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector3 = sector3 + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else if (sec == "4")
                            {
                                while (true)
                                {
                                    Console.WriteLine("Cuántos tripulantes ingresará?");
                                    string? trip = Console.ReadLine();
                                    if (int.TryParse(trip, out int numero))
                                    {
                                        if (numero <= tripulantes && numero >= 0)
                                        {
                                            sector4 = sector4 + numero;
                                            tripulantes = tripulantes - numero;
                                            der = der + numero;
                                            break;
                                        }
                                        else if (numero > tripulantes || numero < 0)
                                        {
                                            Console.WriteLine("ERROR: Tripulantes insuficientes.");
                                            Console.WriteLine($"Solo hay {tripulantes} disponibles, reingrese datos:");
                                            trip = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una cantidad válida:");
                                            trip = Console.ReadLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingrese una cantidad válida.");
                                        trip = Console.ReadLine();
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Ingrese un número entero.");
                                sec = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El dato ingresado es incorrecto o no existe.");
                        Console.WriteLine("Solo hay 2 zonas:    [1] o [2]");
                        zonas = Console.ReadLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: El dato ingresado no existe o es incorrecto.");
                    Console.WriteLine("Solo es [Izq] o [Der].");
                    alas = Console.ReadLine();
                }

                
            }
        }
    }
}