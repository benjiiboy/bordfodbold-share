using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordfodbold_console
{
    class Program
    {
        static void Main(string[] args)
        {
            HoldList MinListe = new HoldList();

            //laver et nyt hold og tilføjet til dic
            MinListe.AddHoldToList(new hold("hold1", "spiller1", "spiller2"));
            MinListe.AddHoldToList(new hold("hold2", "spiller1", "spiller2"));


            MinListe.AddHoldToList(new hold("hold3", "spiller1", "spiller2"));
            MinListe.AddHoldToList(new hold("hold4", "spiller1", "spiller2"));
            MinListe.AddHoldToList(new hold("hold5", "spiller1", "spiller2"));
            MinListe.AddHoldToList(new hold("hold6", "spiller1", "spiller2"));
            MinListe.AddHoldToList(new hold("hold7", "spiller1", "spiller2"));

            MinListe.LookUpHold("hold3").AddVundet();
            MinListe.LookUpHold("hold3").AddVundet();
            MinListe.LookUpHold("hold4").AddVundet();
            MinListe.LookUpHold("hold3").AddVundet();
            MinListe.LookUpHold("hold1").AddVundet();
            MinListe.LookUpHold("hold2").AddVundet();
            MinListe.LookUpHold("hold3").AddVundet();

            Console.WriteLine(MinListe.OrderByGoal());
            // tilføje
            MinListe.LookUpHold("hold1").Addgoal(5);
            //printer mål
            Console.WriteLine(MinListe.LookUpHold("hold1").Antalgoal());

            //fjerner mål
            MinListe.LookUpHold("hold1").Addgoal(-2);
            //printer mål (kontrol af remove metoede)
            Console.WriteLine(MinListe.LookUpHold("hold1").Antalgoal());


            

            //printer alle hold
            MinListe.PrintAlleHold();

            //kontrol af lookup virker som den skal (det gør den)
            Console.WriteLine(MinListe.LookUpHold("hold2").GetHoldnavn());

            Console.WriteLine("tilføjet win");
            //tilføjer vundet til hold2
            MinListe.LookUpHold("hold2").AddVundet();

            //se antal kampe
            Console.WriteLine(MinListe.LookUpHold("hold2").GetAntalKampe());
            

            //ser om GetAntalPoint metoede virker til udregning af points
            Console.WriteLine("antal point");
            Console.WriteLine(MinListe.LookUpHold("hold2").GetAntalPoint());
            MinListe.LookUpHold("hold2").AddVundet();
            Console.WriteLine(MinListe.LookUpHold("hold2").GetAntalPoint());

            MinListe.PrintHighestTeamScore();

            Console.ReadKey();
        }
    }
}
