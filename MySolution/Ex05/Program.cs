            Console.Write("Insira um número inteiro positivo: ");
            int numeroLimite = int.Parse(Console.ReadLine());

            if (numeroLimite <= 0)
            {
                Console.WriteLine("O número deve ser positivo. Tente novamente.");
                return;
            }

            int anterior = 0;
            int atual = 1;
            int proximo;

            Console.WriteLine(anterior);
            Console.WriteLine(atual);

            for (int i = 2; i <= numeroLimite; i++)
            {
                proximo = anterior + atual;
                Console.WriteLine(proximo);

                anterior = atual;
                atual = proximo;
            }