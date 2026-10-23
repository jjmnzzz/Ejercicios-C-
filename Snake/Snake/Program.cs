using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Snake
{
    // Dimensiones del tablero
    const int Ancho = 30;
    const int Alto = 15;

    // Estructura para representar posiciones en la pantalla
    struct Posicion
    {
        public int X;
        public int Y;
        public Posicion(int x, int y) 
        { 
            X = x; 
            Y = y; 
        }
    }

    enum Direccion { Arriba, Abajo, Izquierda, Derecha }

    static void Main(string[] args)
    {
        // Configurar la ventana de la consola
        Console.CursorVisible = false;
        Console.WindowWidth = Ancho + 2;
        Console.WindowHeight = Alto + 4;

        // Inicializar juego
        List<Posicion> snake = new List<Posicion> { new Posicion(20, 10), new Posicion(20, 11), new Posicion(20, 12) };
        Direccion dir = Direccion.Arriba;
        Random random = new Random();
        Posicion comida = GenerarComida(snake, random);
        int puntuacion = 0;
        bool juegoTerminado = false;

        DibujarBordes();

        // Bucle principal del juego
        while (!juegoTerminado)
        {
            // Leer teclado si hay una tecla presionada
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow: if (dir != Direccion.Abajo) dir = Direccion.Arriba; break;
                    case ConsoleKey.DownArrow: if (dir != Direccion.Arriba) dir = Direccion.Abajo; break;
                    case ConsoleKey.LeftArrow: if (dir != Direccion.Derecha) dir = Direccion.Izquierda; break;
                    case ConsoleKey.RightArrow: if (dir != Direccion.Izquierda) dir = Direccion.Derecha; break;
                }
            }

            // Calcular la nueva posición de la cabeza
            Posicion cabeza = snake.First();
            Posicion nuevaCabeza = cabeza;

            switch (dir)
            {
                case Direccion.Arriba: nuevaCabeza.Y--; break;
                case Direccion.Abajo: nuevaCabeza.Y++; break;
                case Direccion.Izquierda: nuevaCabeza.X--; break;
                case Direccion.Derecha: nuevaCabeza.X++; break;
            }

            // Comprobar colisiones con bordes o con el propio cuerpo
            if (nuevaCabeza.X <= 0 || nuevaCabeza.X >= Ancho + 1 || nuevaCabeza.Y <= 0 || nuevaCabeza.Y >= Alto + 1 || snake.Contains(nuevaCabeza))
            {
                juegoTerminado = true;
                break;
            }

            // Insertar nueva cabeza
            snake.Insert(0, nuevaCabeza);

            // Comprobar si come la comida
            if (nuevaCabeza.X == comida.X && nuevaCabeza.Y == comida.Y)
            {
                puntuacion += 10;
                comida = GenerarComida(snake, random);
            }
            else
            {
                // Si no come, borra la cola en pantalla y la elimina de la lista
                Posicion cola = snake.Last();
                Console.SetCursorPosition(cola.X, cola.Y);
                Console.Write(" ");
                snake.RemoveAt(snake.Count - 1);
            }

            // Dibujar juego
            DibujarJuego(snake, comida, puntuacion);

            // Velocidad del juego (mientras menor el número, más rápido va)
            Thread.Sleep(100);
        }

        // Pantalla de Game Over
        Console.SetCursorPosition(Ancho / 4, Alto / 2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"¡GAME OVER! Puntuación final: {puntuacion}");
        Console.ResetColor();
        Console.SetCursorPosition(0, Alto + 2);
        Console.ReadKey();
    }

    static void DibujarBordes()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i <= Ancho + 1; i++)
        {
            Console.SetCursorPosition(i, 0); Console.Write("█");
            Console.SetCursorPosition(i, Alto + 1); Console.Write("█");
        }
        for (int i = 0; i <= Alto + 1; i++)
        {
            Console.SetCursorPosition(0, i); Console.Write("█");
            Console.SetCursorPosition(Ancho + 1, i); Console.Write("█");
        }
    }

    static void DibujarJuego(List<Posicion> snake, Posicion comida, int puntuacion)
    {
        // Dibujar comida
        Console.SetCursorPosition(comida.X, comida.Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("O");

        // Dibujar cuerpo de la serpiente
        for (int i = 0; i < snake.Count; i++)
        {
            Console.SetCursorPosition(snake[i].X, snake[i].Y);
            Console.ForegroundColor = i == 0 ? ConsoleColor.DarkGreen : ConsoleColor.Green;
            Console.Write(i == 0 ? "@" : "o");
        }

        // Mostrar puntuación
        Console.SetCursorPosition(2, Alto + 2);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Puntos: {puntuacion}  ");
    }

    static Posicion GenerarComida(List<Posicion> snake, Random random)
    {
        Posicion comida;
        do
        {
            comida = new Posicion(random.Next(1, Ancho + 1), random.Next(1, Alto + 1));
        } while (snake.Contains(comida)); // Asegurar que no aparezca encima de la serpiente

        return comida;
    }
}