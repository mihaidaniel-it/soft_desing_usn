if (args.Length > 0 && args[0] == "9")
{
    Task09();
    return;
}

Task01();
Task02();
Task03();
Task04();
Task05();
Task06();
Task07();
Task08();
Task09Info();
Task10();
Task11();
Task12();

static void CompileError(string error)
{
    Console.WriteLine("Не компилируется: " + error);
}

// Две разные переменные
static void Task01()
{
    int a = 5;
    F();

    static void F()
    {
        int b = 6;
        Console.WriteLine($"проверка: внутри F b = {b}");
    }

    Console.WriteLine($"проверка: после F a = {a}, b больше не существует");
}

// Две переменные с тем же именем
static void Task02()
{
    int a = 5;
    F();

    static void F()
    {
        int a = 6;
        Console.WriteLine($"проверка: внутри F a = {a}");
    }

    Console.WriteLine($"проверка: после F a = {a}");
}

// Использование переменной после завершения функции
static void Task03()
{
    CompileError("error CS0103: Имя \"b\" не существует в текущем контексте.");
}

// Перезапись переданной переменной
static void Task04()
{
    int a = 5;
    F(a);

    static void F(int b)
    {
        b = 6;
        Console.WriteLine($"проверка: внутри F b = {b}");
    }

    Console.WriteLine($"проверка: после F a = {a}");
}

// Перезапись переданной переменной с тем же именем
static void Task05()
{
    int a = 5;
    F(a);

    static void F(int a)
    {
        a = 6;
        Console.WriteLine($"проверка: внутри F a = {a}");
    }

    Console.WriteLine($"проверка: после F a = {a}");
}

// Два параметра (1)
static void Task06()
{
    int b = 6;
    F(1, b);

    static int F(int a, int b)
    {
        return a + b;
    }

    Console.WriteLine($"проверка: b = {b}");
}

// Два параметра (2)
static void Task07()
{
    int b = 6;
    int s = F(1, b);
    b = s;

    static int F(int a, int b)
    {
        return a + b;
    }

    Console.WriteLine($"проверка: b = {b}, s = {s}");
}

// Передача вызова функции параметром
static void Task08()
{
    int b = 6;
    int s = F(F(1, F(2, b)), b);

    static int F(int a, int b)
    {
        return a + b;
    }

    Console.WriteLine($"проверка: b = {b}, s = {s}");
}

// Функция, вызывающая себя
static void Task09()
{
    F(1);

    static void F(int a)
    {
        F(a);
    }
}

static void Task09Info()
{
    Console.WriteLine("Пропущено: бесконечная рекурсия завершается Stack overflow.");
    Console.WriteLine("Запустить отдельно: dotnet run -- 9");
}

// Копирование аргументов
static void Task10()
{
    int a = 1;
    F(a + 2);
    a = 10;

    static void F(int x)
    {
        Console.WriteLine(x);
    }

    Console.WriteLine($"проверка: a = {a}");
}

// Передача параметра, его смена после вызова
static void Task11()
{
    int a = 1;
    int b = F(a);
    a = 2;

    Console.WriteLine(a);
    Console.WriteLine(b);

    static int F(int x)
    {
        return x;
    }
}

// Тип результата выражения
static void Task12()
{
    string s = GetGreeting();
    Console.WriteLine(s);

    static string GetGreeting()
    {
        return "Привет";
    }
}
