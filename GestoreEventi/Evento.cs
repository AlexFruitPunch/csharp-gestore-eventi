using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int numeroPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPrenotati)
        {
            this.titolo = titolo;
            this.data = data;   
            this.capienzaMassima = capienzaMassima; 
            this.numeroPrenotati = numeroPrenotati; 
        }

        //------ Getters ------

        public string GetTitolo()
        {
            return titolo;
        }

        public DateTime GetData()
        {
            return data;
        }

        public int GetcapienzaMassima()
        {
            return capienzaMassima;
        }

        public int GetnumeroPrenotati(){ 
            return numeroPrenotati;
        }

        //------ Setters ------

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void Setdata(DateTime data)
        {
            this.data = data;
        }

        public void SetcapienzaMassima(int capienzaMassima)
        {
            this.capienzaMassima = capienzaMassima;
        }
        public void SetnumeroPrenotati(int numeroPrenotati)
        {
            this.numeroPrenotati = numeroPrenotati;
        }
    }

}
