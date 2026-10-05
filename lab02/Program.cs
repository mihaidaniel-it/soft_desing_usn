Console.WriteLine(" Задание 2.1");
Console.WriteLine("Hello, Jerry");

Console.WriteLine("Задание 2.2Э");
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);

Console.WriteLine("Задание 2.3");
A();
A();
A();

Console.WriteLine("Задание 2.4");
Console.WriteLine("NeverCalled не вызвана, ее строка не напечаталась.");

Console.WriteLine("Задание 2.5");
DefinedFirst();


void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void A()
{
    Console.WriteLine("A: начало");
    B();
    C();
    Console.WriteLine("A: конец");
}

void B()
{
    Console.WriteLine("  B");
}

void C()
{
    Console.WriteLine("  C");
}

void NeverCalled()
{
    Console.WriteLine("Этот текст никогда не напечатается");
}

void DefinedFirst()
{
    Console.WriteLine("DefinedFirst вызывает DefinedLater:");
    DefinedLater();
}

void DefinedLater()
{
    Console.WriteLine("  DefinedLater выполнилась");
}
