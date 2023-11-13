int salariobase, horasextras, salariohora, acrescimosalario;

mensagem("-- CÁLCULO DE HORAS EXTRAS --", ConsoleColor.White);
mensagem2("Por favor, digite seu nome... ", ConsoleColor.Yellow); 
string nome = Convert.ToString(Console.ReadLine()!);

mensagem2($"Olá, {nome}. ", ConsoleColor.White);
mensagem2("Digite o seu salário-base...: ", ConsoleColor.White);
salariobase = Convert.ToInt32(Console.ReadLine()!);

mensagem2("Digite seu salário-hora para calcularmos o acréscimo no salário-base...: ", ConsoleColor.Gray);
salariohora = Convert.ToInt32(Console.ReadLine()!);

mensagem2("Digite quantas horas você trabalha por dia...: ", ConsoleColor.White);
int horas = Convert.ToInt32(Console.ReadLine()!);

mensagem2("Digite quantas horas extras você fez esse mês...: ", ConsoleColor.White);
horasextras = Convert.ToInt32(Console.ReadLine()!);

Thread.Sleep(1500);

mensagem("Calculando o acréscimo... ", ConsoleColor.DarkGray);
calcAcrescimo();

Thread.Sleep(1500);

mensagem($"Chegamos em um resultado, Sr(a).{nome}! ", ConsoleColor.White);
Thread.Sleep(1500);
mensagem($"Seu salário final é de R${acrescimosalario}", ConsoleColor.DarkGreen);

Thread.Sleep(1500);

mensagem("Obrigado por usar o programa!", ConsoleColor.White);

Thread.Sleep(1500);

mensagem("Volte sempre!", ConsoleColor.White);

void mensagem2(string mensagem, ConsoleColor corTexto)
{
    Console.ForegroundColor = corTexto;
    Console.Write(mensagem);
    Console.ResetColor();
}

void mensagem(string mensagem, ConsoleColor corTexto)
{
    Console.ForegroundColor = corTexto;
    Console.WriteLine(mensagem);
    Console.ResetColor();
}

void calcAcrescimo()
{
    acrescimosalario = Convert.ToInt32(salariobase + (salariohora * 1.4 * horasextras));
}