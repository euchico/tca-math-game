using MathGame.View;

namespace MathGame;

internal class MathGame
{
    static void Main(string[] args)
    {
        MainScreen screen = new MainScreen();
        screen.Show();

        Console.Write("Opção: ");
        int operation = int.Parse(Console.ReadLine()!);

        Console.Write(operation);

        Console.ReadKey();
    }
}