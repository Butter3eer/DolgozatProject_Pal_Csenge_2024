namespace DolgozatProject
{
    public class Dolgozat : IDolgozat
    {
        private List<int> pontok;

        public Dolgozat()
        {
            pontok = new List<int>();
        }

        public List<int> Pontok { get => pontok; }
        public int Bukas 
        {
            get
            {
                int buktak = 0;
                foreach (var pont in Pontok)
                {
                    if (pont != -1 && pont < 50)
                    {
                        buktak++;
                    }
                }
                return buktak;
            }
            
        }
        public int Elegseges
        {
            get
            {
                int elegseges = 0;
                foreach (var pont in Pontok)
                {
                    if (pont <= 60 && pont >= 50)
                    {
                        elegseges++;
                    }
                }
                return elegseges;
            }
        }
        public int Kozepes
        {
            get
            {
                int kozepes = 0;
                foreach (var pont in Pontok)
                {
                    if (pont <= 70 && pont >= 61)
                    {
                        kozepes++;
                    }
                }
                return kozepes;
            }
        }
        public int Jo
        {
            get
            {
                int jo = 0;
                foreach (var pont in Pontok)
                {
                    if (pont <= 80 && pont >= 71)
                    {
                        jo++;
                    }
                }
                return jo;
            }
        }
        public int Jeles
        {
            get
            {
                int jeles = 0;
                foreach (var pont in Pontok)
                {
                    if (pont >= 81)
                    {
                        jeles++;
                    }
                }
                return jeles;
            }
        }
        public bool Ervenytelen
        {
            get
            {
                int nemIrtDolgozatot = 0;
                foreach (var pont in Pontok)
                {
                    if (pont == -1)
                    {
                        nemIrtDolgozatot++;
                    }
                }

                int feleADolgozatnak = Convert.ToInt16(Math.Ceiling(pontok.Count / 2.0));

                if (nemIrtDolgozatot >= feleADolgozatnak && pontok.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Gyanus(int kivalok)
        {
            if (kivalok < 0)
            {
                throw new ArgumentOutOfRangeException("Kiválók száma nagyobb vagy egyenlő kell legyen a 0-val.");
            }
            else if (kivalok < Jeles)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MindenkiMegirta()
        {
            if (pontok.Contains(-1) || pontok.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }   
        }

        public void Pontfelvesz(int x)
        {
            if (x < -1 || x > 100)
            {
                throw new ArgumentOutOfRangeException("A pontszám -1-től 100-ig terjedő lehet.");
            }
            else
            {
                pontok.Add(x);
            }
        }
    }
}