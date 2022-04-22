using GestoreEventi;

//nome Evento
Console.Write("inserisci il nome dell'evento: ");
string? nomeEvento = Console.ReadLine();
while(nomeEvento == null)
{
    nomeEvento = Console.ReadLine();
}

//data Evento
Console.Write("\ninserisci la data dell'evento(gg/mm/yyyy): ");
DateTime dataEvento = DateTime.Parse(Console.ReadLine());

//numero posti totali
Console.Write("\ninserisci il numero di posti totali: ");
int postiTotaliEvento = int.Parse(Console.ReadLine());

//Posti da prenotare
Console.Write("Vuoi già prenotare dei posti?[si/no]");

bool controlloScelta = false; //controlloScelta si riferisce al controllo si/no
string? imputUtente = Console.ReadLine().ToLower();
int postiDaPrenotare = 0;

while (controlloScelta == false)
{
    switch (imputUtente)
    {
        case "si":
            Console.Write("\nQuanti posti vuoi prenotare? ");
            postiDaPrenotare = int.Parse(Console.ReadLine());
            controlloScelta = true;
            break;
        case "no":
            postiDaPrenotare = 0;
            controlloScelta = true;
            break;
        default:
            Console.WriteLine("imput errato, devi inserire o si o no");
            break;
    }
}

Evento nuovoEvento = new Evento(nomeEvento, dataEvento, postiTotaliEvento, postiDaPrenotare);

//Resoconto posti disponibili/prenotati
Console.Write("Numero di posti prenotati: " + nuovoEvento.GetpostiPrenotati());
Console.Write("\nNumero di posti prenotati: " + nuovoEvento.PostiDisponibili());

//Disdici posti prenotazione
Console.Write("\n\nVuoi disdire dei posti (si/no)? ");

imputUtente = Console.ReadLine().ToLower();
controlloScelta = false;
bool continuare = true; //continuare si riferisce al controllo se continuare a disdire o meno

while(continuare == true) { 
    while (controlloScelta == false)
    {
        switch (imputUtente)
        {
            case "si":
                Console.WriteLine("Indica il numero di posti da disdire");
                int numeroDaDisdire = int.Parse(Console.ReadLine());
                for (int i=0; i< numeroDaDisdire; i++)
                {
                    nuovoEvento.Disdici();
                }
                controlloScelta = true;
                Console.WriteLine("Vuoi disdire altri posti ?(si/no)");
                string ulterioreScelta = Console.ReadLine().ToLower();
                    switch (ulterioreScelta)
                    {
                    case "si":
                        controlloScelta = false;
                        break;
                    case "no":
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("imput errato");
                        break;
                    }
                break;
            case "no":
                controlloScelta = true;
                break;
            default:
                Console.WriteLine("imput errato, devi inserire o si o no");
                break;
        }
    }
}

//Resoconto post disdicitura posti disponibili/prenotati
Console.Write("Numero di posti prenotati: " + nuovoEvento.GetpostiPrenotati());
Console.Write("\nNumero di posti prenotati: " + nuovoEvento.PostiDisponibili());