// See https://aka.ms/new-console-template for more information

//Utenti


//Prestiti

//Banca



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

    public List<Clients> searchClient(string name, string surname)
    {
        List<Clients> results = new List<Clients>();

        foreach (Clients client in clients)
        {
            if(client.Name + client.Surname == name + surname)
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

