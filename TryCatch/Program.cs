


try
{
    Console.WriteLine("informe o primeiro valor!");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o segundo valor!");
    int b = Convert.ToInt32(Console.ReadLine());
    int r = a / b;
    Console.WriteLine($"O resultado é {r}");
}catch(Exception ex)
{
    Console.WriteLine($"Não é permitido divisão por zero! { ex.Message}");
} 