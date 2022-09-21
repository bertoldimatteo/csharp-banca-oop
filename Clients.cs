// See https://aka.ms/new-console-template for more information

//Utenti


//Prestiti

//Banca



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

