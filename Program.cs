using Helper.Dao;


// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

ClienteDao cliente = new ClienteDao
{
    Nome = "Fernando Pontes",
    Idade = 43,
    CPF = "12345678900"
};

Console.WriteLine(Helper.Linefy.ToLine<ClienteDao>(cliente));