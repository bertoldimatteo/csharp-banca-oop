// See https://aka.ms/new-console-template for more information

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
    static public int clientID;
}

class Loans
{
    private int id;
    private string client;
    private int amount;
    private int rate;
    private int startRateYear;
    private int endRateYear;
}