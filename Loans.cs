// See https://aka.ms/new-console-template for more information

//Utenti


//Prestiti

//Banca



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

