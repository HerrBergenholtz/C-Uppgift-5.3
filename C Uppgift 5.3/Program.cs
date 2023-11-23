using System;

namespace Uppgift_5._3
{
    class Program
    {
        public static void Main()
        {
            try
            {
                string[] frågor = { "Vad heter du Ameen?", "Vad heter jag?", "Vad heter Johan?", "Vad heter Rafaella?" };
                string[] svar = { "Ameen", "Zacharias", "Johan", "Rafaella" };
                bool running = true;
                while (running)
                {
                    Console.WriteLine("Välj en fråga (skriv \"0\" om du vill avsluta)");
                    for (int i = 0; i < frågor.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {frågor[i]}");
                    }
                    int frågaInput = int.Parse(Console.ReadLine());

                    switch (frågaInput)
                    {
                        case 1:
                            FrågaAnvändare(frågaInput, frågor, svar);
                            break;
                        case 2:
                            FrågaAnvändare(frågaInput, frågor, svar);
                            break;
                        case 3:
                            FrågaAnvändare(frågaInput, frågor, svar);
                            break;
                        case 4:
                            FrågaAnvändare(frågaInput, frågor, svar);
                            break;
                        case 0:
                        running = false;
                            break;
                    }
                }
                Console.WriteLine("Tack för att du deltog");
            }   
            catch
            {
                Console.WriteLine("Du gav inte rätt input, försök igen");
                Console.ReadLine();
                Main();
            }
        }
        public static void FrågaAnvändare(int frågaInput, string[] frågor, string[] svar)
        {
            Console.WriteLine(frågor[frågaInput - 1]);
            string frågaSvar = Console.ReadLine().ToLower();
            if (frågaSvar == svar[frågaInput - 1].ToLower())
            {
                Console.WriteLine("Grattis du svarade rätt!");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Tyvärr fel svar :(");
                Console.ReadLine();
            }
        }
    }
}