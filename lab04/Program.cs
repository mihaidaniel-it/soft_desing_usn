// Лабораторная работа 4. Базовое взаимодействие с памятью через переменные.
// Каждый пример из задания — отдельная функция TaskNN с исходным кодом примера.
// Строки с пометкой "проверка" добавлены, чтобы увидеть значения всех переменных в конце.
// Примеры, которые не компилируются, оставлены в комментариях вместе с реальной ошибкой компилятора.
// Объяснения — в README.md.

Task01();
Task02();
Task03();
Task03Swap();
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


static void Header(string title)
{
    Console.WriteLine();
    Console.WriteLine($"--- {title} ---");
}

static void CompileError(string error)
{
    Console.WriteLine("Не компилируется: " + error);
}

// 1. Определение переменной
static void Task01()
{
    Header("1. Определение переменной");

    int a = 5;
    Console.WriteLine(a);
}

// 2. Присваивание одной переменной к другой
static void Task02()
{
    Header("2. Присваивание одной переменной к другой");

    int a = 5;
    int b = 6;
    a = b;
    b = 7;
    Console.WriteLine(a);

    Console.WriteLine($"проверка: a = {a}, b = {b}");
}

// 3. Попытка обмена значениями
static void Task03()
{
    Header("3. Попытка обмена значениями");

    int a = 1;
    int b = 2;
    a = b;
    b = a;
    Console.WriteLine(a);
    Console.WriteLine(b);
}

// 3 (дополнительно). Правильный обмен через временную переменную
static void Task03Swap()
{
    Header("3. Правильный обмен через temp");

    int a = 1;
    int b = 2;
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine(a);
    Console.WriteLine(b);
}

// 4. Присваивание выражения, включающего переменную
static void Task04()
{
    Header("4. Присваивание выражения, включающего переменную");

    int a = 5;
    int b = a + 6;
    a = 7;
    Console.WriteLine(b);

    Console.WriteLine($"проверка: a = {a}, b = {b}");
}

// 5. Литералы, переменные и операторы — это выражения
static void Task05()
{
    Header("5. Литералы, переменные и операторы — это выражения");

    int a = 5;
    int b = a;
    int c = a + 6;
    Console.WriteLine(b);
    Console.WriteLine(c);
}

// 6. Присваивание как выражение
static void Task06()
{
    Header("6. Присваивание как выражение");

    int a = 5;
    int c = (a = 7);
    Console.WriteLine(a);
    Console.WriteLine(c);
}

// 7. Присваивание ссылочной переменной
static void Task07()
{
    Header("7. Присваивание ссылочной переменной");

    string a = "1";
    string b = a;
    a = "2";
    Console.WriteLine(a);
    Console.WriteLine(b);
}

// 8. Присваивание int к string
static void Task08()
{
    Header("8. Присваивание int к string");

    // string a = 5;
    CompileError("error CS0029: Не удается неявно преобразовать тип \"int\" в \"string\".");
}

// 9. Создание переменной с тем же именем
static void Task09()
{
    Header("9. Создание переменной с тем же именем");

    // int a = 5;
    // int a = 6;
    CompileError("error CS0128: Локальная переменная или функция с именем \"a\" уже определена в этой области.");
}

// 10. Имена, отличающиеся только регистром
static void Task10()
{
    Header("10. Имена, отличающиеся только регистром");

    int a = 5;
    int A = 6;
    Console.WriteLine(a);
    Console.WriteLine(A);
}

// 11. Регистр в именах методов
static void Task11()
{
    Header("11. Регистр в именах методов");

    // console.WriteLine("Hello");
    CompileError("error CS0103: Имя \"console\" не существует в текущем контексте.");
}

// 12. Вывод типа через var
static void Task12()
{
    Header("12. Вывод типа через var");

    var a = 5;
    Console.WriteLine(a);

    Console.WriteLine($"проверка: тип a = {a.GetType().Name}");
    // a = "abc"; // error CS0029: Не удается неявно преобразовать тип "string" в "int".
}

// 13. var без инициализации
static void Task13()
{
    Header("13. var без инициализации");

    // var a;
    // a = 5;
    CompileError("error CS0818: Неявно типизированные переменные должны быть инициализированы");
}

// 14. var от другой переменной
static void Task14()
{
    Header("14. var от другой переменной");

    int a = 5;
    var b = a + 5;
    Console.WriteLine(b);

    Console.WriteLine($"проверка: тип b = {b.GetType().Name}");
}
