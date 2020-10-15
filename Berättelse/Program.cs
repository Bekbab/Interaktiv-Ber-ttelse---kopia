using System;

namespace Berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till en interaktiv berättelse");
            
            Console.WriteLine("Du vaknar upp i ett mörkt rum. Framför dig finns ett bord. På bordet ligger en pilbåge med en pil och ett svärd.");
           
            Console.WriteLine("Ta svärdet och pilbågen? j/n");

            //första frågan           
           
            string opt1;

            opt1 = Console.ReadLine();
            
            //Lämnat vapen
            if (opt1 == "n")
            {
                Console.WriteLine("Du lämnar vapnen och trevar dig fram i mörkret. Du hör ett ljud bakom dig och vänder dig om förskräckt. Bakom dig står ett monster. Du springer för ditt liv men den kommer långsamt närmare. Du snubblar på något i mörkret och monstret kommer ikapp dig.");
                Console.WriteLine("Du dog. Om ändå du hade haft några vapen!");
            }

            //Ta med vapen
            if (opt1 == "j")
            {
                Console.WriteLine("Du tar svärdet och pilbågen och trevar dig fram i mörkret. Du hör ett ljud bakom dig och vänder dig om förskräckt. Bakom dig står ett monster.");
                Console.WriteLine("Vad gör du? svärd/båge/fly");
                
                
                string monster;

                monster = Console.ReadLine();

                //Svärd/dödat monster med svärd
                if (monster == "svärd")
                {
                    Console.WriteLine("Med ett hastigt hugg klyver du monstret itu. Lättat fortsätter du vidare genom mörkret. Plötsligt lyses rummet upp. En jättelik brinnande fladdermus flaxar ned från taket. Det finns ingenstans att fly");
                    Console.WriteLine("Vad gör du? svärd/båge/");

                    string fladdermus1;

                    fladdermus1 = Console.ReadLine();

                    //Svärd/missade fladdermusen
                    if (fladdermus1 == "svärd")
                    {
                        Console.WriteLine("Du hugger efter fladdermusen med ditt svärd men den är för högt upp. Fladddermusen flaxar kraftigt med sina massiva vingar. Brännheta vindar grillar dig levande");
                        Console.WriteLine("Du dog. Om ändå du hade haft något som kunde nå lite längre.");
                    }
                    
                    if (fladdermus1== "båge")
                    {
                        Console.WriteLine("Du lägger en pil på bågsträngen, spänner och släpper iväg den mot fladdermusen. Pilen träffar fladdermusen i hjärtat. Med ett högsljutt skri faller den till marken. En dörr öppnas bakom dig som leder till säkerheten.");
                        Console.WriteLine("Du tog dig ut levande! Bra jobbat!");


                    }


                }

                //monster dödat med båge
                if (monster == "båge")
                {

                    Console.WriteLine("Du lägger en pil på bågsträngen, spänner och släpper iväg den. Den träffar monstret i hjärtat. Rytandes kollapsar den. Lättad, fortsätter du vidare genom mörkret. Plötsligt lyses rummet upp. En jättelik brinnande fladdermus flaxar ned från taket. Det finns ingenstans att fly. Du har inga fler pilar så du hugger efter fladdermusen med ditt svärd men den är för högt upp. Fladddermusen flaxar kraftigt med sina massiva vingar. Brännheta vindar grillar dig levande ");
                    Console.WriteLine("Du dog. Om ändå du hade haft något som kunde nå lite längre.");

                }

                //Försökte fly
                if (monster == "fly")
                {
                    Console.WriteLine("Du springer för ditt liv men den kommer långsamt närmare. Du snubblar på något i mörkret och monstret kommer ikapp dig.");
                    Console.WriteLine("Du dog. Monster bryr sig inte om du är pacifist eller inte.");


                }

            }
              
            
            Console.ReadLine();
        }
    }
}
