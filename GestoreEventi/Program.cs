using GestoreEventi;

//nome Evento
Console.Write("inserisci il nome dell'evento: ");
string? nomeEvento = Console.ReadLine();
while(nomeEvento == null)
{
    nomeEvento = Console.ReadLine();
}

//data Evento
Console.Write("inserisci la data dell'evento(gg/mm/yyyy): ");
DateTime dataEvento = DateTime.Parse(Console.ReadLine());

//numero posti totali
Console.Write("inserisci il numero di posti totali: ");
int postiTotaliEvento = int.Parse(Console.ReadLine());

//Posti da prenotare
Console.Write("Vuoi già prenotare dei posti[si/no]? ");

bool controlloScelta = false; //controlloScelta si riferisce al controllo si/no
string? inputUtente = Console.ReadLine().ToLower();
int postiDaPrenotare = 0;

while (controlloScelta == false)
{
    switch (inputUtente)
    {
        case "si":
            Console.Write("Quanti posti vuoi prenotare? ");
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
ResocontoPosti();

//Disdici posti prenotazione
Console.Write("\n\nVuoi disdire dei posti (si/no)? ");

inputUtente = Console.ReadLine().ToLower();
controlloScelta = false;
bool continuare = true; //continuare si riferisce al controllo se continuare a disdire o meno

while(continuare == true) { 
    while (controlloScelta == false)
    {
        switch (inputUtente)
        {
            case "si":
                Console.Write("Indica il numero di posti da disdire: ");
                int numeroDaDisdire = int.Parse(Console.ReadLine());
                for (int i=0; i< numeroDaDisdire; i++)
                {
                    nuovoEvento.Disdici();
                }
                controlloScelta = true;
                ResocontoPosti();
                Console.Write("\nVuoi disdire altri posti (si/no)? ");
                string ulterioreScelta = Console.ReadLine().ToLower();
                    switch (ulterioreScelta)
                    {
                    case "si":
                        controlloScelta = false;
                        break;
                    case "no":
                        Console.WriteLine("ok va bene!");
                        ResocontoPosti();
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("imput errato");
                        break;
                    }
                break;
            case "no":
                controlloScelta = true;
                continuare = false;
                break;
            default:
                Console.WriteLine("imput errato, devi inserire o si o no");
                break;
        }
    }
}








//------ funzioni ------
void ResocontoPosti()
{
    Console.Write("\nNumero di posti prenotati: " + nuovoEvento.GetpostiPrenotati());
    Console.Write("\nNumero di posti rimanenti: " + nuovoEvento.PostiDisponibili() + "\n");
}