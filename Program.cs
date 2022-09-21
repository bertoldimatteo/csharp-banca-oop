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

class Bank
{
    private string name;
    public string Name { get; set; }

    List<Clients> clients;

    List<Loans> loans;

    public Bank(string name)
    {
        this.Name = name;

        clients = new List<Clients>();
        loans = new List<Loans>();  
    }

    public void addClient(Clients client)
    {
        clients.Add(client);
    }

    public void editClient(Clients client, string name, string surname, double salary)
    {
        client.Name = name;
        client.Surname = surname;
        client.Salary = salary;
    }

    public void addLoans(Loans loan)
    {
        loans.Add(loan);
    }

    public List<Clients> searchClient(int id, string name, string surname)
    {
        List<Clients> results = new List<Clients>();

        foreach (Clients client in clients)
        {
            if(client.Id + client.Name + client.Surname == id + name + surname)
            {
                results.Add(client);    
            }
        }
        return results;
    }

    public List<Loans> searchLoans(string fiscalCode)
    {
        List<Loans> results = new List<Loans>();

        foreach (Loans loan in loans)
        {
            if (loan.clients.FiscalCode == fiscalCode)
            {
                results.Add(loan);
            }
        }
        return results;
    }

    public int totalLoans(string fiscalCode)
    {
        List<Loans> results = searchLoans(fiscalCode);
        int initLoan = 0;
        
        foreach(Loans loan in results)
        {
            initLoan += loan.Amount;
        }
        return initLoan;
    }

}

class Clients
{
    private int id;
    private string name;
    private string surname;
    private string fiscalCode;
    private double salary;
    private int loans;
    static public int currentClientID = 1;

    //Getter Setter
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FiscalCode { get; set; }
    public double Salary { get; set; }
    
    public Clients(string name, string surname, string fiscalCode, double salary)
    {
        this.Name = name;
        this.Surname = surname;
        this.FiscalCode = fiscalCode;   
        this.Salary = salary;
        this.Id = Clients.currentClientID++;
    }

    
}

class Loans
{
    private int id;
    public Clients clients;
    private int amount;
    private double rate;
    private int startRateYear;
    private int endRateYear;
    static public int currentLoanID = 1;
    public int Id { get; set; }
    public int Amount { get; set; }
    public double Rate { get; set; }   
    public int StartRateYear { get; set; }
    public int EndRateYear { get; set; }

    public Loans(Clients clients, int amount, double rate, int startRateYear)
    {
        this.Id = Loans.currentLoanID++;
        this.clients = clients;
        this.amount = amount;
        this.rate = rate;
        this.StartRateYear = startRateYear;
    }
}

