Task01();
Task02();
Task03();
Task04();
Task05();
Task06();
Task07();
Task08();
Task09();
Task10();
Task11();
Task12();
Task13();
Task14();
Task15();
Task16();
Task17();
Task17Extra();

// Что печатает true
static void Task01()
{
    bool a = true;
    Console.WriteLine(a);
}

// Присвоение пустой ссылки к bool
static void Task02()
{
    // bool a = null;
    Console.WriteLine("Не компилируется: error CS0037: Не удается преобразовать значение NULL в \"bool\", " +
        "поскольку этот тип значений не допускает значение NULL.");
}

// Сравнение это логическое выражение
static void Task03()
{
    bool a = 1 == 2;
    Console.WriteLine(a);
}

// Сравнение переменных это выражение
static void Task04()
{
    int x = 3;
    int y = 4;
    bool b = x == y;
    Console.WriteLine(b);
}

// Сложное сравнение переменных
static void Task05()
{
    int x = 3;
    int y = 4;
    bool b = x * 2 == y + 4;
    Console.WriteLine(b);
}

// Перезапись bool переменной
static void Task06()
{
    bool a = 1 > 2;
    Console.WriteLine($"проверка: после первой строки a = {a}");
    a = 3 == 3;
    Console.WriteLine(a);
}

// Передача bool переменной функции
static void Task07()
{
    bool a = true;
    F(a);

    static void F(bool x)
    {
        Console.WriteLine(x);
    }
}

// Передача bool выражения функции
static void Task08()
{
    F(5 > 3);

    static void F(bool flag)
    {
        Console.WriteLine(flag);
    }
}

// Возвращение bool значения
static void Task09()
{
    bool result = F();
    Console.WriteLine(result);

    static bool F()
    {
        return true;
    }
}

// Возвращение bool выражения
static void Task10()
{
    bool result = IsGreater(5, 3);
    Console.WriteLine(result);

    static bool IsGreater(int a, int b)
    {
        return a > b;
    }
}

// Сравнение логических значений
static void Task11()
{
    bool a = true;
    bool b = false;
    bool c = a == b;
    Console.WriteLine(c);
}

// Оператор !
static void Task12()
{
    bool a = false;
    bool b = !a;
    Console.WriteLine(b);
}

// Оператор &&
static void Task13()
{
    bool a = true;
    bool b = false;
    bool c = a && b;
    Console.WriteLine(c);
}

// Тонкости оператора && (1)
static void Task14()
{
    bool result = A() && B();

    static bool A()
    {
        Console.WriteLine("A");
        return true;
    }

    static bool B()
    {
        Console.WriteLine("B");
        return true;
    }

    Console.WriteLine($"проверка: result = {result}");
}

// Тонкости оператора && (2)
static void Task15()
{
    bool result = A() && B();

    static bool A()
    {
        Console.WriteLine("A");
        return true;
    }

    static bool B()
    {
        Console.WriteLine("B");
        return false;
    }

    Console.WriteLine($"проверка: result = {result}");
}

// Тонкости оператора && (3)
static void Task16()
{
    bool result = A() && B();

    static bool A()
    {
        Console.WriteLine("A");
        return false;
    }

    static bool B()
    {
        Console.WriteLine("B");
        return true;
    }

    Console.WriteLine($"проверка: result = {result}");
}

// Тонкости оператора ||
static void Task17()
{
    bool result = A() || B();

    static bool A()
    {
        Console.WriteLine("A");
        return true;
    }

    static bool B()
    {
        Console.WriteLine("B");
        return true;
    }

    Console.WriteLine($"проверка: result = {result}");
}

// когда первый операнд false — второй вычисляется
static void Task17Extra()
{
    bool result = A() || B();

    static bool A()
    {
        Console.WriteLine("A");
        return false;
    }

    static bool B()
    {
        Console.WriteLine("B");
        return true;
    }

    Console.WriteLine($"проверка: result = {result}");
}
