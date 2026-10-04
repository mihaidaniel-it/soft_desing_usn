// Лабораторная работа 2. Понимание базового проекта.
// Задание 1 (компиляция, bin/obj, выполнимый файл) описано в README.md.

// --- Задание 2.1 ---
Console.WriteLine("--- 2.1 ---");
Console.WriteLine("Hello, Jerry");

// --- Задание 2.2 ---
// Функция печатает A, B, C; выполняем ее 3 раза с задержкой 0.5 с после каждого выполнения.
Console.WriteLine("--- 2.2 ---");
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);

// --- Задание 2.3 ---
// A вызывает B и C; A вызываем несколько раз.
Console.WriteLine("--- 2.3 ---");
A();
A();
A();

// --- Задание 2.4 ---
// NeverCalled определена ниже, но нигде не вызывается,
// поэтому ее текст в консоль не попадет.
Console.WriteLine("--- 2.4 ---");
Console.WriteLine("NeverCalled не вызвана, ее строка не напечаталась.");

// --- Задание 2.5 ---
// DefinedFirst определена раньше DefinedLater, но вызывает ее.
Console.WriteLine("--- 2.5 ---");
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
