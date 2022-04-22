using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> eventi = new List<Evento>();

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
        }

        //Metodi

        public void AggiungiEvento(Evento nomEvento)
        {
            eventi.Add(nomEvento);
        }
        /*public Evento GetListaRicercata(DateTime dataDaCercare)
            {
                List<Evento> listaEventi = new List<Evento>();

                foreach (Evento evento in eventi)
                {
                if (eventi.Exists(x => x.GetData() == dataDaCercare))
                    {
                        return listaEventi;
                    }
            }*/

        public static void StampaLista()
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                Evento nomEvento = eventi[i];
                Console.WriteLine(nomEvento.ToString());
            }
        }

        public void GetListaDiEventi()
        {
            Console.WriteLine(titolo + ":");
            foreach (Evento nomEvento in eventi)
            {
                Console.WriteLine(nomEvento.GetData() + " - " + nomEvento.GetTitolo());
            }

        }

        public int ContaElementi()
        {
            return eventi.Count;
        }

        public void SvuotaLista()
        {
            eventi.Clear();
        }


        //------- Getters - Setters ---------
        public string GetTitolo()
        {
            return titolo;
        }

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }


    }
}

