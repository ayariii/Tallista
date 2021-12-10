using System;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();

            int returnValue = random.Next(1, 100);
            int Guess = 0;
            int count = 0;

            Console.WriteLine("Skriv ett number mellan 1 och 100 och försök gissa det tal datorn ");

            while (Guess != returnValue)
                {
                
                string line = Console.ReadLine();
                 
                if (!int.TryParse(line, out Guess))
                    Console.WriteLine("Inte en Integer, Grrrr");
                
                else {
                    count++;
                    
                    if (Guess < returnValue)
                        {
                            Console.WriteLine("Datorns tal är högre än " + Guess + ". Försök igen");
                        }
                    
                        if (Guess > returnValue)
                            {
                                Console.WriteLine("Datorns tal är mindre än " + Guess + ". Försök igen");
                            }

                    }
                }

                    Console.WriteLine("Najs, talet var " + returnValue + " och du tog " + count + " försök på dig att gissa rätt svar!");
                    Console.WriteLine("Skriv Dotnet Run för att spela igen");
                    Console.ReadLine();
    }

}