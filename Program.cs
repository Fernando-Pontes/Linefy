using Helper.Helper.Dao;


// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

ClienteDao cliente = new ClienteDao
{
    Nome = "Fernando Pontes",
    Idade = 43,
    CPF = "28076447836"
};

Helper.Helper.Linefy.ToLine<ClienteDao>(cliente,';',false);