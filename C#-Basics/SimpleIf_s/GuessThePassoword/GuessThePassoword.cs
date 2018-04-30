namespace GuessThePassoword
{
    using System;

    class GuessThePassoword
    {
        static void Main()
        {
            var input = Console.ReadLine();
            if ("s3cr3t!P@ssw0rd" == input)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
