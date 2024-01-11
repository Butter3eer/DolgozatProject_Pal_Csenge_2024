using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatProject
{
    internal interface IDolgozat
    {
        void Pontfelvesz(int x);
        bool MindenkiMegirta();
        bool Gyanus(int kivalok);
    }
}
