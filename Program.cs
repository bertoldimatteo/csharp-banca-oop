// See https://aka.ms/new-console-template for more information

Client user1 = new Client("Mario", "Rossi", "AAAAA", 25000.00);
Client user2 = new Client("Paolo", "Biondi", "BBBBB", 17000.10);
Client user3 = new Client("Carlo", "Neri", "CCCCC", 4900.80);

class Bank
{
    private string name;

    //un insieme di clienti (una lista)

    //un insieme di prestiti concessi ai clienti (una lista)
}

class Client
{
    private string name;
    private string surname;
    private string fiscalCode;
    private double salary;
    static public int clientID = 0;

    //Getter Setter
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
        Client.clientID++;
    }

    
}

class Loans
{
    static public int loanID = 0;
    private string client;
    private int amount;
    private int rate;
    private int startRateYear;
    private int endRateYear;
    public string Client { get; set; }
    public int Amount { get; set; }
    public int Rate { get; set; }   
    public int StartRateYear { get; set; }
    public int EndRateYear { get; set; }

    public Loans(string client, int amount, int rate, int startRateYear, int endRateYear)
    {
        this.Client = client;
        this.Amount = amount;
        this.Rate = rate;
        this.StartRateYear = startRateYear;
        this.EndRateYear = endRateYear;
        Loans.loanID++;
    }
}

