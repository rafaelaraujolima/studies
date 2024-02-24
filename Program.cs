// See https://aka.ms/new-console-template for more information

using Studies;

public static class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(String.Join(" ", SolutionMoveZeroes.MoveZeroes([0,1,0,0,3,4,0,5,0])));
    }
}
