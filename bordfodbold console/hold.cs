using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordfodbold_console
{
  public  class hold
    {
        //instance field
        private string Holdnavn;
        private string Spiller1;
        private string spiller2;
        public int goal;
        private int antalKampe;
        private int antalPoint;
        private int antalTabte;
        private int antalVundet;

        //constructor
        public hold(string Holdnavn, string spiller1, string spiller2)
        {
            this.Holdnavn = Holdnavn;
            this.Spiller1 = spiller1;
            this.spiller2 = spiller2;
            this.goal = 0;
            this.antalKampe = 0;
            this.antalPoint = 0;
            this.antalVundet = 0;
            this.antalTabte = 0;

        }
        // metoder til at get holdnavn samt spiller navn
        public string GetHoldnavn()
        {
            return Holdnavn;
        }
        public string GetTopScore()
        {
            return Spiller1;
        }
        public string GetSpiller()
        {
            return Spiller1 + " " + spiller2;
        }
        public int GetAntalKampe()
        {
            return antalVundet + antalTabte;
        }
        public int GetAntalPoint()
        {
            return UdregnHoldPoint();
        }
        public int Getvundet()
        {
            return antalVundet;
        }
        public int GetTabt()
        {
            return antalTabte;
        }


        //lave metoder der tilføjer X mål
        // smid "-" indforan for at fjerne mål
        public void Addgoal(int antal)
        {
             goal = antal + goal;
        }
        public int Antalgoal()
        {
            return goal;
        } 

        public int UdregnHoldPoint()
        {
            return antalPoint + (antalVundet *3);
        }
        // tilføjer kun 1 da man kun vinder en af gang
        public void AddVundet()
        {
            antalVundet = antalVundet + 1;
        }
        // tilføjer kun 1 da man kun taber en af gang
        public void AddTabt()
        {
            antalTabte = antalTabte + 1;
        }

        public override string ToString()
        {
            return $"Hold={Holdnavn} Antal mål={goal}";
        }
    }

}
