using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordfodbold_console
{
    class HoldList
    {
        //instance field vil være holdnavnet og value vil være hold obj
        Dictionary<string, hold> Holdliste;

        public HoldList()
        {
            Holdliste = new Dictionary<string, hold>();
        }

        //her tilføjre vi et hold list vores dictionary
        public void AddHoldToList(hold aHold)
        {
            Holdliste.Add(aHold.GetHoldnavn(), aHold);
        }

        //vil vi også gerne kunne fjerne hold fra listen (holdnavn da vores Tkey er holdnavn)
        public void RemoveHoldFromList(string HoldNavn)
        {
            Holdliste.Remove(HoldNavn);
        }

        //vi vil gerne kunne se alle hold 
        // samt printe
        public void PrintAlleHold()
        {
            foreach (KeyValuePair<string, hold> i in Holdliste)
            {
                hold aHold = i.Value;
                Console.WriteLine($"Hold navn :{aHold.GetHoldnavn()}, Spillere {aHold.GetSpiller()}");
            }
        }

        /// <summary>
        /// denne metode ser alle vores hold igennem vi sætter highscore til at være 0 og derefter sammenligner vi
        /// den går igennem hvert hold og via "større mindre" finder den det største i.value er holdets mål og ahold = i.value er hold navn
        /// 
        /// </summary>
        public void PrintHighestTeamScore()
        {            
            int highScore = 0;
            hold aHold = null;

            foreach (KeyValuePair<string, hold> i in Holdliste)
            {                            

                if (i.Value.Antalgoal() > highScore)
                {
                    highScore = i.Value.Antalgoal();
                    aHold = i.Value; 
                }
               
            }

            Console.WriteLine($"{aHold.GetTopScore()} har en highscore på {highScore}");

        }

        //mulighed for at søge på holdnavn (det er Tkey)
        public hold LookUpHold(string HoldNavn)
        {
            if (Holdliste.ContainsKey(HoldNavn))
            {
                return Holdliste[HoldNavn];
            }
            else
                return null;
        }


        public void OrderByGoal()
        {
            var varnavn = from hold in Holdliste
                          orderby hold.Value.Antalgoal() descending
                          select hold;
        }





    }
}

