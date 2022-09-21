// See https://aka.ms/new-console-template for more information

Client user1 = new Client("Mario", "Rossi", "AAAAA", 25000.00);
Client user2 = new Client("Paolo", "Biondi", "BBBBB", 17000.10);
Client user3 = new Client("Carlo", "Neri", "CCCCC", 4900.80);

Console.WriteLine($"ID cliente {user1.Id} Nome cliente {user1.Name}");
Console.WriteLine($"ID cliente {user2.Id} Nome cliente {user2.Name}");

Loans loan1 = new Loans("user1", 15000, 312.50, 2022, 2024);
Loans loan2 = new Loans("user2", 30000, 625.00, 2022, 2024);
Loans loan3 = new Loans("user3", 5000, 106.34, 2022, 2024);

class Bank
{
    private string name;

    //un insieme di clienti (una lista)

    //un insieme di prestiti concessi ai clienti (una lista)
}

class Client
{
    private int id;
    private string name;
    private string surname;
    private string fiscalCode;
    private double salary;
    static public int currentClientID = 1;

    //Getter Setter
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FiscalCode { get; set; }
    public double Salary { get; set; }
    
    public Client(string name, string surname, string fiscalCode, double salary)
    {
        this.Name = name;
        this.Surname = surname;
        this.FiscalCode = fiscalCode;   
        this.Salary = salary;
        this.Id = Client.currentClientID++;
    }

    
}

class Loans
{
    static public int loanID = 0;
    private string client;
    private double amount;
    private double rate;
    private int startRateYear;
    private int endRateYear;
    public string Client { get; set; }
    public double Amount { get; set; }
    public double Rate { get; set; }   
    public int StartRateYear { get; set; }
    public int EndRateYear { get; set; }

    public Loans(string client, double amount, double rate, int startRateYear, int endRateYear)
    {
        this.Client = client;
        this.Amount = amount;
        this.Rate = rate;
        this.StartRateYear = startRateYear;
        this.EndRateYear = endRateYear;
        Loans.loanID++;
        Console.WriteLine(Loans.loanID);
    }
}

