namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name= Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favColor= (Console.ReadLine());
            Console.WriteLine("What is your favorite animal?");
            string favAnimal= Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand= Console.ReadLine();
            
            Console.WriteLine($"\nName: {name}\nFavorite Color: {favColor}\nFavorite Animal: {favAnimal}\nFavorite Band: {favBand}\n");
            
            Console.WriteLine("Let's write a fun short story with the answers you provided!\n");
            Console.WriteLine($"Hello my name is {name}! A long time ago I saw {favBand} in person. They are my favorite band. I decided to wear {favColor} because it's also my favorite color. Then on the way home I saw a {favAnimal} my favorite animal! What a crazy lucky day right?");
        }
    }
}
