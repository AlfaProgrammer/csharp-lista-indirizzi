// See https://aka.ms/new-console-template for more information

StreamReader address = File.OpenText(@"C:\Users\alexl\source\repos\ListaIndirizzi\addresses.csv");

string format = address.ReadLine();


    while(!address.EndOfStream)
    {
        string row = address.ReadLine();
        Console.WriteLine(row);
    }

address.Close();

//Console.WriteLine(format);