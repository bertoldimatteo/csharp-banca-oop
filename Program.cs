// See https://aka.ms/new-console-template for more information

//Utenti
Clients user1 = new Clients("Mario", "Rossi", "AAAAA", 25000.00);
Clients user2 = new Clients("Paolo", "Biondi", "BBBBB", 17000.10);
Clients user3 = new Clients("Carlo", "Neri", "CCCCC", 4900.80);

Console.WriteLine($"ID cliente {user1.Id} Nome cliente {user1.Name}");
Console.WriteLine($"ID cliente {user2.Id} Nome cliente {user2.Name}");

//Prestiti
Loans loan1 = new Loans(user1, 15000, 2022);
Loans loan2 = new Loans(user2, 30000, 2022);
Loans loan3 = new Loans(user3, 5000, 2022);

//Banca
Bank bank1 = new Bank("Unicredit");

//aggiungere, modificare e ricercare un cliente.
bank1.addClient(user1);
bank1.addClient(user2);
bank1.addClient(user3);

bank1.editClient(user2, "Alan", "Caulo", 5000.00);

Console.WriteLine(user2.Name);

List<Clients> resultClient = bank1.searchClient("Alan", "Caulo");
if(resultClient.Count == 0)
{
    Console.WriteLine("Nessun utente trovato");
}
else
{
    Console.WriteLine("Utente trovato");
}

//aggiungere un prestito.
Loans firstLoan = new Loans(user1, 5000, 2022);
Loans secondLoan = new Loans(user1, 8000, 2022);
Loans thirdLoan = new Loans(user2, 16000, 2022);

//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
List<Loans> resultLoans = bank1.searchLoans("AAAAA");
if (resultLoans.Count == 0)
{
    Console.WriteLine("Prestito trovato");
}
else
{
    Console.WriteLine("Prestito non trovato");
}