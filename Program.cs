namespace Ikilisayi;

class Program
{
    static void Main(string[] args)
    {
          string input = Console.ReadLine();
          string[] numbers=input.Split(' ');
          int islem=0;
          for (int i = 1; i < numbers.Length; i++)
          {
            if (int.Parse(numbers[i])==int.Parse(numbers[i-1]))
                {islem=int.Parse(numbers[i]) +int.Parse( numbers[i-1]);Console.Write(" "+islem*islem);i++;}
            else
                {islem=int.Parse(numbers[i]) +int.Parse( numbers[i-1]);Console.Write(" "+islem);i++;}
          }    
        Console.ReadLine();
    }
}
