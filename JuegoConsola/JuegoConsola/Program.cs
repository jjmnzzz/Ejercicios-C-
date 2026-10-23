using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JuegoConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuración inicial de la consola
            Console.CursorVisible = false;
            int anchoVentana = 3;
            int altoVentana =18;
            Console.SetWindowSize(anchoVentana, altoVentana);

            // Posición del jugador (Nave 'A')
            int jugadorX = anchoVentana / 2;
            int jugadorY = altoVentana - 3;

            // Posición del obstáculo (Asteroide '*')
            Random random = new Random();
            int obstaculoX = random.Next(0, anchoVentana);
            int obstaculoY = 0;

            // Posición del bonus (Bonus '·')
            int bonusX = random.Next(0, anchoVentana); 
            int bonusY = -10;

            int puntuacion = 0;
            bool jugando = true;

            Console.Clear();

            // Bucle principal del juego
            while (jugando)
            {
                // --- 1. LEER ENTRADA DEL JUGADOR ---
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.LeftArrow && jugadorX > 0)
                    {
                        jugadorX--;
                    }
                    if (tecla.Key == ConsoleKey.RightArrow && jugadorX < anchoVentana - 1)
                    {
                        jugadorX++;
                    }
                }

                obstaculoY++; // El asteroide cae un lugar hacia abajo

                // Si el asteroide llega al suelo, reaparece arriba
                if (obstaculoY >= altoVentana)
                {
                    obstaculoY = 0;
                    puntuacion++; // Suma un punto por esquivarlo
                    obstaculoX = random.Next(0, anchoVentana);
                    
                    

                }

                if (random.Next(0,3) == 0 && bonusY < 0)
                {
                    bonusY = 0;
                    bonusX = random.Next(0, anchoVentana);
                }

                if (bonusY >= 0)
                {
                    bonusY++;
                }

                if (bonusY >= altoVentana)
                {
                    bonusY = 0;
                }

                // Comprobar colisión (si coinciden las coordenadas)
                if (jugadorX == obstaculoX && jugadorY == obstaculoY)
                {
                    jugando = false; // Fin del juego
                }
                    
                //bonusY++; // El asteroide cae un lugar hacia abajo

                // Si el asteroide llega al suelo, reaparece arriba
                /*if (bonusY >= altoVentana)
                {
                    bonusY = 0;
                    do
                    {
                        bonusX = random.Next(0, anchoVentana);
                    } while (bonusX == obstaculoX);
                }*/

                // Comprobar colisión (si coinciden las coordenadas)
                if (jugadorX == bonusX && jugadorY == bonusY)
                {
                    puntuacion = puntuacion + 5;
                    bonusY = 0;
                }
                

                // --- 3. DIBUJAR EN PANTALLA ---
                Console.Clear();

                // Dibujar jugador
                Console.SetCursorPosition(jugadorX, jugadorY);
                Console.Write("A");

                // Dibujar obstáculo
                Console.SetCursorPosition(obstaculoX, obstaculoY);
                Console.Write("*");

                // Dibujar bonus
                if (bonusY >= 0 && bonusY < anchoVentana)
                {
                    Console.SetCursorPosition(bonusX, bonusY);
                    Console.Write("·");
                }
                

                // Mostrar puntuación
                Console.SetCursorPosition(0, 0);
                Console.Write($"Puntos: {puntuacion}");

                Console.SetCursorPosition(0, altoVentana-1);
                Console.Write("|||");
                Console.SetCursorPosition(0, altoVentana - 2);
                Console.Write("^^^");

                // --- 4. CONTROL DE VELOCIDAD ---
                Thread.Sleep(50); // Pausa de 50 milisegundos por fotograma
            }

            // --- FIN DEL JUEGO ---
            Console.Clear();
            Console.SetCursorPosition(anchoVentana / 4, altoVentana / 2);
            Console.WriteLine($"¡GAME OVER! Puntos totales: {puntuacion}");
            Console.SetCursorPosition(anchoVentana / 4, (altoVentana / 2) + 1);
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadLine();
        }
    }
}
