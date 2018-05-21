using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Menu
    {
        public int HamburguesaSencilla;
        public int HamburguesaQueso;
        public int HamburguesaEspecial;
        public int PatatasFritas;
        public int Refresco;
        public int Postre;

        public void AddHamburguesaSencilla()
        {
            HamburguesaSencilla++;
        }
        public void AddHamburguesaQueso()
        {
            HamburguesaQueso++;
        }
        public void AddHamburguesaEspecial()
        {
            HamburguesaEspecial++;
        }
        public void AddPatatasFritas()
        {
            PatatasFritas++;
        }
        public void AddRefresco()
        {
            Refresco++;
        }
        public void AddPostre()
        {
            Postre++;
        }

        public int CalcularTotal()
        {
            int total = 0;

            total += HamburguesaSencilla * 5;
            total += HamburguesaQueso * 8;
            total += HamburguesaEspecial * 10;
            total += PatatasFritas * 3;
            total += Refresco * 2;
            total += Postre * 3;

            return total;
        }

    }
}
