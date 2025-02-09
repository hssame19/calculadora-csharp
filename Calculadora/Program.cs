static float PowerCalc(float num1, float num2)
{
    switch(num1)
    {
        case 0:
            return 0;

        case 1:
            return 1;
    }
    switch (num2)
    {
        case 0:
            return 1;

        case 1:
            return num1;
    }

    //float resultado = num1 * PowerCalc(num1, num2 - 1);           - Só funciona com inteiros
    //return resultado;                                             - Stack overflow; Não existe um caso base para números decimais, ocasionando em recursão infinita.

    return (float)Math.Pow(num1, num2);                         
}

bool working = true;

while(working == true)
{
    Console.WriteLine();
    Console.WriteLine("Digite o primeiro número: ");
    Console.WriteLine();
    string num1String = Console.ReadLine();
    float num1 = float.Parse(num1String);

    Console.WriteLine();
    Console.WriteLine("Digite o segundo número: ");
    Console.WriteLine();
    string num2String = Console.ReadLine();
    float num2 = float.Parse(num2String);

    Console.WriteLine();
    Console.WriteLine("Escolha qual operação você deseja fazer:");
    Console.WriteLine("1. Adição");
    Console.WriteLine("2. Subtração");
    Console.WriteLine("3. Multiplicação");
    Console.WriteLine("4. Divisão");
    Console.WriteLine("[E] 5. Resto da divisão");
    Console.WriteLine("[E] 6. Potência (onde o primeiro número é a base e o segundo número o expoente)");
    Console.WriteLine("9. Voltar ao início");
    Console.WriteLine("0. Sair do programa");
    Console.WriteLine();

    string escolhaString = Console.ReadLine();
    int escolha = Int32.Parse(escolhaString);
    Console.WriteLine();
    float resultado;

    switch (escolha)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma entre {num1} e {num2} é {resultado}.");
            break;

        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração entre {num1} e {num2} é {resultado}.");
            break;

        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação entre {num1} e {num2} é {resultado}.");
            break;

        case 4:
            resultado = num1 / num2;
            Console.WriteLine($"O resultado da divisão entre {num1} e {num2} é {resultado}.");
            break;

        case 5:
            resultado = num1 % num2;
            Console.WriteLine($"O resto da divisão entre {num1} e {num2} é {resultado}.");
            break;

        case 6:
            int num1Int = (int)num1;
            int num2Int = (int)num2;

            resultado = PowerCalc(num1, num2);
            Console.WriteLine($"{num1} elevado a {num2} é igual a {resultado}.");
            break;

        case 9:
            Console.WriteLine("Voltando ao início...");
            break;

        case 0:
            working = false;
            Console.WriteLine("Terminando o programa...");
            break;

        default:
            Console.WriteLine("Você precisa escolher uma das opções dadas (1 a 4, 9 ou 0).");
            break;
    }
} 