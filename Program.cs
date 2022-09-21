// See https://aka.ms/new-console-template for more information

//Utenti
Clients user1 = new Clients("Mario", "Rossi", "AAAAA", 25000.00);
Clients user2 = new Clients("Paolo", "Biondi", "BBBBB", 17000.10);
Clients user3 = new Clients("Carlo", "Neri", "CCCCC", 4900.80);

Console.WriteLine($"ID cliente {user1.Id} Nome cliente {user1.Name}");
Console.WriteLine($"ID cliente {user2.Id} Nome cliente {user2.Name}");

//Prestiti
Loans loan1 = new Loans(user1, 15000, 312.50, 2022);
Loans loan2 = new Loans(user2, 30000, 625.00, 2022);
Loans loan3 = new Loans(user3, 5000, 106.34, 2022);

//Banca
Bank bank1 = new Bank("Unicredit");

bank1.addClient(user1);
bank1.addClient(user2);
bank1.addClient(user3);

bank1.editClient(user2, "Alan", "Caulo", 5000.00);

Console.WriteLine(user2.Name);

List<Clients> result = bank1.searchClient("Alan", "Caulo");
if(result.Count == 0)
{
    Console.WriteLine("Nessun utente trovato");
}
else
{
    Console.WriteLine("Utente trovato");
}