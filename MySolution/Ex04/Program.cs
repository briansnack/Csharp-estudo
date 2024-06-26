        Console.Write("Insira a idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        if (idade <= 13){
            Console.WriteLine("Criança");
        } else if (idade > 13 && idade <= 18){
            Console.WriteLine("Adolescente");
        } else if (idade > 18 && idade <= 60){
            Console.WriteLine("Adulto");
        } else{
            Console.WriteLine("Idoso");
        }
