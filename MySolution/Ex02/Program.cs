    Console.Write("Quantidade de reais: ");
    double real = double.Parse(Console.ReadLine());
        double dolar = real / 5.17;
        double euro = real / 6.14;
        double pesoArgentino = real / 0.05;

        Console.WriteLine("Dólar = " + dolar); 
        Console.WriteLine("Euro = " + euro); 
        Console.WriteLine("Peso Argentino = " + pesoArgentino); 


