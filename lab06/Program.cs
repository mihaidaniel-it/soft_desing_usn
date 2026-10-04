// Лабораторная работа 6. Логические выражения и операторы.
// Каждый пример из задания — отдельная функция TaskNN с исходным кодом примера.
// Строки с пометкой "проверка" добавлены, чтобы увидеть значения переменных.
// Пример 2 не компилируется, он оставлен в комментарии вместе с реальной ошибкой компилятора.
// Объяснения — в README.md.

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


static void Header(string title)
{
    Console.WriteLine();
    Console.WriteLine($"--- {title} ---");
}

// 1. Что печатает true
static void Task01()
{
    Header("1. Что печатает true");

    bool a = true;
    Console.WriteLine(a);
}

// 2. Присвоение пустой ссылки к bool
static void Task02()
{
    Header("2. Присвоение пустой ссылки к bool");

    // bool a = null;
    Console.WriteLine("Не компилируется: error CS0037: Не удается преобразовать значение NULL в \"bool\", " +
        "поскольку этот тип значений не допускает значение NULL.");
}

// 3. Сравнение это логическое выражение
static void Task03()
{
    Header("3. Сравнение это логическое выражение");

    bool a = 1 == 2;
    Console.WriteLine(a);
}

// 4. Сравнение переменных это выражение
static void Task04()
{
    Header("4. Сравнение переменных это выражение");

    int x = 3;
    int y = 4;
    bool b = x == y;
    Console.WriteLine(b);
}

// 5. Сложное сравнение переменных
static void Task05()
{
    Header("5. Сложное сравнение переменных");

    int x = 3;
    int y = 4;
    bool b = x * 2 == y + 4;
    Console.WriteLine(b);
}

// 6. Перезапись bool переменной
static void Task06()
{
    Header("6. Перезапись bool переменной");

    bool a = 1 > 2;
    Console.WriteLine($"проверка: после первой строки a = {a}");
    a = 3 == 3;
    Console.WriteLine(a);
}

// 7. Передача bool переменной функции
static void Task07()
{
    Header("7. Передача bool переменной функции");

    bool a = true;
    F(a);

    static void F(bool x)
    {
        Console.WriteLine(x);
    }
}

// 8. Передача bool выражения функции
static void Task08()
{
    Header("8. Передача bool выражения функции");

    F(5 > 3);

    static void F(bool flag)
    {
        Console.WriteLine(flag);
    }
}

// 9. Возвращение bool значения
static void Task09()
{
    Header("9. Возвращение bool значения");

    bool result = F();
    Console.WriteLine(result);

    static bool F()
    {
        return true;
    }
}

// 10. Возвращение bool выражения
static void Task10()
{
    Header("10. Возвращение bool выражения");

    bool result = IsGreater(5, 3);
    Console.WriteLine(result);

    static bool IsGreater(int a, int b)
    {
        return a > b;
    }
}

// 11. Сравнение логических значений
static void Task11()
{
    Header("11. Сравнение логических значений");

    bool a = true;
    bool b = false;
    bool c = a == b;
    Console.WriteLine(c);
}

// 12. Оператор !
static void Task12()
{
    Header("12. Оператор !");

    bool a = false;
    bool b = !a;
    Console.WriteLine(b);
}

// 13. Оператор &&
static void Task13()
{
    Header("13. Оператор &&");

    bool a = true;
    bool b = false;
    bool c = a && b;
    Console.WriteLine(c);
}

// 14. Тонкости оператора && (1)
static void Task14()
{
    Header("14. Тонкости оператора && (1)");

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

// 15. Тонкости оператора && (2)
static void Task15()
{
    Header("15. Тонкости оператора && (2)");

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

// 16. Тонкости оператора && (3)
static void Task16()
{
    Header("16. Тонкости оператора && (3)");

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

// 17. Тонкости оператора ||
static void Task17()
{
    Header("17. Тонкости оператора ||");

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

// 17 (дополнительно). || когда первый операнд false — второй вычисляется
static void Task17Extra()
{
    Header("17 (доп.). Оператор ||, первый операнд false");

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
