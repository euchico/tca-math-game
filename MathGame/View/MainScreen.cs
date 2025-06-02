namespace MathGame.View;

internal class MainScreen
{
    internal void Show()
    {
        Console.WriteLine(">>> Jogo Matemático <<<\n");

        Console.WriteLine("Escolha o modo de jogo:");
        Console.WriteLine("1. Adição");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        Console.WriteLine("5. Modo Aleatório\n");

        Console.WriteLine("0. Sair\n");
    }
}