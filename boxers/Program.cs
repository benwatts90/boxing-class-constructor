using System;

namespace boxers
{
    class Program
    {
        public static void createCanelo()
        {
            Fighter Canelo = new Fighter("Saul", "Alvarez", 168, "'Canelo'", 58, 2, 2, true, "IBF World, WBA Super World, WBC World, WBO World", true, "5", "Champion", "Champion", "Champion",
                "Champion", "Champion", "Matchroom Boxing");
          
            Console.WriteLine("Fighter Name: " + Canelo.firstName + " " + Canelo.nickname + " " + Canelo.lastName);
            Console.WriteLine("Fighter Weight: " + Canelo.weight);
            Console.WriteLine("Record: W-" + Canelo.wins + " L-" + Canelo.losses + " D-" + Canelo.draws);
            if (Canelo.champion == true) 
            {
                Canelo.ibfRank = null;
                Canelo.iboRank = null;
                Canelo.wboRank = null;
                Canelo.wbcRank = null;
                Canelo.wbaRank = null;
                Console.WriteLine("Titles: " + Canelo.belts);
            } else
            {
                Console.WriteLine("Governing body rankings: IBF: " + Canelo.ibfRank + " IBO: " + Canelo.iboRank + " WBO: " + Canelo.wboRank + " WBA: " + Canelo.wbaRank
                + " WBC: " + Canelo.wbcRank);
            }
            if (Canelo.p4p == true)
            {
                Console.WriteLine("Pound for pound ranking(Ring Magazine): " + Canelo.p4pRank);
            } else
            {
                Canelo.p4pRank = null;
            }
            Console.WriteLine("Promotion company: " + Canelo.promotion);
        }
        public static void createCrawford()
        {
            Fighter Crawford = new Fighter("Terrence", "Crawford", 147, "'Bud'", 38, 0, 0, true, "WBO World", true, "3", "", "", "",
                "", "", "Premier Boxing Champions");

            Console.WriteLine("Fighter Name: " + Crawford.firstName + " " + Crawford.nickname + " " + Crawford.lastName);
            Console.WriteLine("Fighter Weight: " + Crawford.weight);
            Console.WriteLine("Record: W-" + Crawford.wins + " L-" + Crawford.losses + " D-" + Crawford.draws);
            if (Crawford.champion == true)
            {
                Crawford.ibfRank = null;
                Crawford.iboRank = null;
                Crawford.wboRank = null;
                Crawford.wbcRank = null;
                Crawford.wbaRank = null;
                Console.WriteLine("Titles: " + Crawford.belts);
            } else
            {
                Console.WriteLine("Governing body rankings: IBF: " + Crawford.ibfRank + " IBO: " + Crawford.iboRank + " WBO: " + Crawford.wboRank + " WBA: " + Crawford.wbaRank
                + " WBC: " + Crawford.wbcRank);
            }
            if (Crawford.p4p == true)
            {
                Console.WriteLine("Pound for pound ranking(Ring Magazine): " + Crawford.p4pRank);
            } else
            {
                Crawford.p4pRank = null;
            }
            Console.WriteLine("Promotion company: " + Crawford.promotion);
        }

        public static void createEnnis()
        {
            Fighter Ennis = new Fighter("Jaron", "Ennis", 147, "'Boots'", 29, 0, 0, false, "", false, "p4p rank", "1", "2", "2",
                "2", "3", "Premier Boxing Champions");

            Console.WriteLine("Fighter Name: " + Ennis.firstName + " " + Ennis.nickname + " " + Ennis.lastName);
            Console.WriteLine("Fighter Weight: " + Ennis.weight);
            Console.WriteLine("Record: W-" + Ennis.wins + " L-" + Ennis.losses + " D-" + Ennis.draws);
            if (Ennis.champion == true)
            {
                Ennis.ibfRank = null;
                Ennis.iboRank = null;
                Ennis.wboRank = null;
                Ennis.wbcRank = null;
                Ennis.wbaRank = null;
                Console.WriteLine("Titles: " + Ennis.belts);
            }
            else
            {
                Console.WriteLine("Governing body rankings: IBF: " + Ennis.ibfRank + " IBO: " + Ennis.iboRank + " WBO: " + Ennis.wboRank + " WBA: " + Ennis.wbaRank
                + " WBC: " + Ennis.wbcRank);
            }
            if (Ennis.p4p == true)
            {
                Console.WriteLine("Pound for pound ranking(Ring Magazine): " + Ennis.p4pRank);
            } else
            {
                Ennis.p4pRank = null;
            }
            Console.WriteLine("Promotion company: " + Ennis.promotion);
        }
        static void Main(string[] args)
        {
            createCanelo();
            Console.WriteLine(" ");
            createCrawford();
            Console.WriteLine(" ");
            createEnnis();
        }
    }
}

