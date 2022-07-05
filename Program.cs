// See https://aka.ms/new-console-template for more information

using ListaIndirizzi;

StreamReader address = File.OpenText(@"C:\Users\alexl\source\repos\ListaIndirizzi\addresses.csv");

string format = address.ReadLine();


    while(!address.EndOfStream)
    {
        string row = address.ReadLine();
        Console.WriteLine(row);

        string[] data = row.Split(",");       


        Address._addresses.Add(new Address()
        {
            Name = data[0],
            Surname = data[1],
            Street = data[2],
            City = data[3],
            Province = data[4],
            ZIP = int.Parse(data[5]),
        });
    }

address.Close();

//Console.WriteLine(format);