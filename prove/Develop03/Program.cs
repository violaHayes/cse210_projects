class Program
{
    static void Main(string[] args)
    {
        Scripture scripture= new Scripture("And my father dwelt in a tent.","1 Nephi 2:15");
        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Hit enter to hide a word");
            Console.ReadLine();
            if (!scripture.HideRandomWord())
            {
                break;
            }                      
        }
        Console.WriteLine("Good job memorizing");


   
    }

}