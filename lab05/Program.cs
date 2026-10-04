// Лабораторная работа 5. Функции с параметрами.
// Каждый пример из задания — отдельная функция TaskNN с исходным кодом примера.
// Строки с пометкой "проверка" добавлены, чтобы увидеть значения переменных.
// Примеры, которые не компилируются, оставлены в комментариях вместе с реальной ошибкой компилятора.
// Объяснения — в README.md.
//
// Пример 9 (бесконечная рекурсия) роняет программу, поэтому запускается только отдельно:
//   dotnet run -- 9

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


static void Header(string title)
{
    Console.WriteLine();
    Console.WriteLine($"--- {title} ---");
}

static void CompileError(string error)
{
    Console.WriteLine("Не компилируется: " + error);
}

// 1. Две разные переменные
static void Task01()
{
    Header("1. Две разные переменные");

    int a = 5;
    F();

    static void F()
    {
        int b = 6;
        Console.WriteLine($"проверка: внутри F b = {b}");
    }

    Console.WriteLine($"проверка: после F a = {a}, b больше не существует");
}

// 2. Две переменные с тем же именем
static void Task02()
{
    Header("2. Две переменные с тем же именем");

    int a = 5;
    F();

    static void F()
    {
        int a = 6;
        Console.WriteLine($"проверка: внутри F a = {a}");
    }

    Console.WriteLine($"проверка: после F a = {a}");
}

// 3. Использование переменной после завершения функции
static void Task03()
{
    Header("3. Использование переменной после завершения функции");

    // int a = 5;
    // F();
    // b = 7;
    //
    // static void F()
    // {
    //     int b = 6;
    // }
    CompileError("error CS0103: Имя \"b\" не существует в текущем контексте.");
}

// 4. Перезапись переданной переменной
static void Task04()
{
    Header("4. Перезапись переданной переменной");

    int a = 5;
    F(a);

    static void F(int b)
    {
        b = 6;
        Console.WriteLine($"проверка: внутри F b = {b}");
    }

    Console.WriteLine($"проверка: после F a = {a}");
}

// 5. Перезапись переданной переменной с тем же именем
static void Task05()
{
    Header("5. Перезапись переданной переменной с тем же именем");

    int a = 5;
    F(a);

    static void F(int a)
    {
        a = 6;
        Console.WriteLine($"проверка: внутри F a = {a}");
    }

    Console.WriteLine($"проверка: после F a = {a}");
}

// 6. Два параметра (1)
static void Task06()
{
    Header("6. Два параметра (1)");

    int b = 6;
    F(1, b);

    static int F(int a, int b)
    {
        return a + b;
    }

    Console.WriteLine($"проверка: b = {b}");
}

// 7. Два параметра (2)
static void Task07()
{
    Header("7. Два параметра (2)");

    int b = 6;
    int s = F(1, b);
    b = s;

    static int F(int a, int b)
    {
        return a + b;
    }

    Console.WriteLine($"проверка: b = {b}, s = {s}");
}

// 8. Передача вызова функции параметром
static void Task08()
{
    Header("8. Передача вызова функции параметром");

    int b = 6;
    int s = F(F(1, F(2, b)), b);

    static int F(int a, int b)
    {
        return a + b;
    }

    Console.WriteLine($"проверка: b = {b}, s = {s}");
}

// 9. Функция, вызывающая себя
static void Task09()
{
    Header("9. Функция, вызывающая себя");

    F(1);

    static void F(int a)
    {
        F(a);
    }
}

static void Task09Info()
{
    Header("9. Функция, вызывающая себя");
    Console.WriteLine("Пропущено: бесконечная рекурсия завершается Stack overflow.");
    Console.WriteLine("Запустить отдельно: dotnet run -- 9");
}

// 10. Копирование аргументов
static void Task10()
{
    Header("10. Копирование аргументов");

    int a = 1;
    F(a + 2);
    a = 10;

    static void F(int x)
    {
        Console.WriteLine(x);
    }

    Console.WriteLine($"проверка: a = {a}");
}

// 11. Передача параметра, его смена после вызова
static void Task11()
{
    Header("11. Передача параметра, его смена после вызова");

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

// 12. Тип результата выражения
static void Task12()
{
    Header("12. Тип результата выражения");

    string s = GetGreeting();
    Console.WriteLine(s);

    static string GetGreeting()
    {
        return "Привет";
    }

    // Если заменить тип s на int:
    // int s = GetGreeting();
    // error CS0029: Не удается неявно преобразовать тип "string" в "int".
}
