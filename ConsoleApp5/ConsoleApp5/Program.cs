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
        int sector = 0;

        Console.WriteLine("La guerra galáctica ha comenzado. Dos comandantes se enfrentan en un sector del espacio.\n El objetivo es eliminar a la tripulación enemiga antes de que ellos eliminen la tuya.\n\n");
        //Console.ForegroundColor = ConsoleColor.Green;
        for (int a = 0; a < 2; a++)
        {
            Console.WriteLine($"Jugador {a+1}\n");
            Console.WriteLine($"Seleccione Ala:  [Izq] [Der]\n\n");
            string alas = Console.ReadLine();
            Console.WriteLine("En qué zona del ala?  Cápsulas[1] o Habitaciones[2]\n\n");
            string zonas = Console.ReadLine();
            
            while (true)
            {
                if(alas == "Izq" || alas == "izq")
                {  
                    if(zonas == "1")
                    {
                        Console.WriteLine("En que cápsula?   Mando[1], Motores[2], Armamento[3]");
                        string? cap = Console.ReadLine();
                        if(cap == "1")
                        {
                            Console.WriteLine("Cuántos tripulantes ingresará?");
                            string? trip = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Ingrese un número entero.");
                            cap = Console.ReadLine();
                        }
                    }
                    
                }
                else if(alas == "Der" || alas == "der")
                {

                    break;
                }
                else
                {
                    
                }

                if()
            }
        }
    }
}