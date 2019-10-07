using System;

namespace KiviPaberK
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("Palun sisesta oma nimi.");
            userName = Console.ReadLine();

            Console.WriteLine("Tere " + userName + "! " + "Mängime kivi-paber-kääre 3 punktini!");


            int valik;
            string rolls;
            rolls = "true";
            int cpuScore;
            cpuScore = 0;
            int userScore;
            userScore = 0;

            while(rolls == "true")
            {
                if(userScore == 3)
                {
                    Console.WriteLine($"Sa võitsid mängu skooriga {userScore}:{cpuScore}!");
                    Console.ReadLine();
                }
                else if(cpuScore == 3)
                {
                    Console.WriteLine($"Sa kaotasid mängu skooriga {userScore}:{cpuScore}!");
                    Console.ReadLine();
                }
                else
             {
                    

                    Console.WriteLine("Sisesta oma valik! 1=Kivi, 2=Paber, 3=Käärid");



                    valik = int.Parse(Console.ReadLine());

                    if (valik < 1 || valik > 3)
                    {
                        Console.WriteLine("Valik on 1-3ni. 1=Kivi, 2=Paber, 3=Käärid.");

                    }
                    else
                    {
                        if (valik == 1)
                        {
                            Console.WriteLine("Su valikuks on Kivi!");

                        }
                        else if (valik == 2)
                        {
                            Console.WriteLine("Su valikuks on Paber!");

                        }
                        else if (valik == 3)
                        {
                            Console.WriteLine("Su valikuks on Käärid!");

                        }


                        Random RandomGenerator = new Random();
                        int cpuRoll = RandomGenerator.Next(1, 4);

                        if (cpuRoll == 1)
                        {
                            Console.WriteLine("Arvuti valis Kivi!");
                        }
                        else if (cpuRoll == 2)
                        {
                            Console.WriteLine("Arvuti valis Paberi!");
                        }
                        else if (cpuRoll == 3)
                        {
                            Console.WriteLine("Arvuti valis Käärid!");
                        }


                        if (valik == 1 && cpuRoll == 1)
                        {
                            Console.WriteLine("Viik!");
                        }
                        else if (valik == 2 && cpuRoll == 2)
                        {
                            Console.WriteLine("Viik!");
                        }
                        else if (valik == 3 && cpuRoll == 3)
                        {
                            Console.WriteLine("Viik!");
                        }
                        else if (valik == 1 && cpuRoll == 2)
                        {
                            Console.WriteLine("Sa kaotasid!");
                            cpuScore++;
                        }
                        else if (valik == 1 && cpuRoll == 3)
                        {
                            Console.WriteLine("Sa võitsid!");
                            userScore++;
                        }
                        else if (valik == 2 && cpuRoll == 1)
                        {
                            Console.WriteLine("Sa võitsid!");
                            userScore++;
                        }
                        else if (valik == 2 && cpuRoll == 3)
                        {
                            Console.WriteLine("Sa kaotasid!");
                            cpuScore++;
                        }
                        else if (valik == 3 && cpuRoll == 1)
                        {
                            Console.WriteLine("Sa kaotasid!");
                            cpuScore++;
                        }
                        else if (valik == 3 && cpuRoll == 2)
                        {
                            Console.WriteLine("Sa võitsid!");
                            userScore++;

                        }
                        
                    }
                    
                }

            }
                  




            







        }
    }
}
