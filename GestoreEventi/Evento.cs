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
        private int postiAdisposizione;

        // N.B. chiedere per la cosa del solo in lettura dei posti a sedere

        //costruttori
        public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPrenotati)
        {
            SetTitolo(titolo);
            Setdata(data);
            SetcapienzaMassima(capienzaMassima);
            SetnumeroPrenotati(numeroPrenotati);

            /*this.titolo = titolo;
            this.data = data;   
            this.capienzaMassima = capienzaMassima; 
            this.numeroPrenotati = numeroPrenotati; */
        }

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            SetTitolo(titolo);
            Setdata(data);
            SetcapienzaMassima(capienzaMassima);

            /*this.titolo = titolo;
            this.data = data;   
            this.capienzaMassima = capienzaMassima;  */
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
            if (titolo != null)
            {
                this.titolo = titolo;
            }
            else 
            {
                throw new ArgumentNullException("Deve inserire un Titolo caro Utente");
            }
        }

        public void Setdata(DateTime data)
        {
            DateTime dateOdierna = DateTime.Now;   
            if(data <= dateOdierna)
            {
                throw new ArgumentOutOfRangeException("Non puoi inserire una data nel passato");
            }
            else
            { 
                this.data = data;
            }
        }

        public void SetcapienzaMassima(int capienzaMassima)
        {
            if(capienzaMassima < 0) 
            {
                throw new ArgumentOutOfRangeException("non puoi inserire un valore negativo");
            }
            else
            {
                this.capienzaMassima = capienzaMassima;
            }
        }
        public void SetnumeroPrenotati(int numeroPrenotati)
        {
            if (numeroPrenotati < 0)
            {
                throw new ArgumentOutOfRangeException("non puoi inserire un valore negativo");
            }
            else
            {
                this.numeroPrenotati = numeroPrenotati;
            }
            
        }
    }

}
