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

static void CompileError(string error)
{
    Console.WriteLine("Не компилируется: " + error);
}

// Определение переменной
static void Task01()
{
    int a = 5;
    Console.WriteLine(a);
}

// Присваивание одной переменной к другой
static void Task02()
{
    int a = 5;
    int b = 6;
    a = b;
    b = 7;
    Console.WriteLine(a);

    Console.WriteLine($"проверка: a = {a}, b = {b}");
}

// Попытка обмена значениями
static void Task03()
{
    int a = 1;
    int b = 2;
    a = b;
    b = a;
    Console.WriteLine(a);
    Console.WriteLine(b);
}

// Правильный обмен через временную переменную
static void Task03Swap()
{
    int a = 1;
    int b = 2;
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine(a);
    Console.WriteLine(b);
}

// Присваивание выражения, включающего переменную
static void Task04()
{
    int a = 5;
    int b = a + 6;
    a = 7;
    Console.WriteLine(b);

    Console.WriteLine($"проверка: a = {a}, b = {b}");
}

// Литералы, переменные и операторы — это выражения
static void Task05()
{
    int a = 5;
    int b = a;
    int c = a + 6;
    Console.WriteLine(b);
    Console.WriteLine(c);
}

// Присваивание как выражение
static void Task06()
{
    int a = 5;
    int c = (a = 7);
    Console.WriteLine(a);
    Console.WriteLine(c);
}

// Присваивание ссылочной переменной
static void Task07()
{
    string a = "1";
    string b = a;
    a = "2";
    Console.WriteLine(a);
    Console.WriteLine(b);
}

// Присваивание int к string
static void Task08()
{
    // string a = 5;
    CompileError("error CS0029: Не удается неявно преобразовать тип \"int\" в \"string\".");
}

// Создание переменной с тем же именем
static void Task09()
{
    // int a = 5;
    // int a = 6;
    CompileError("error CS0128: Локальная переменная или функция с именем \"a\" уже определена в этой области.");
}

//  Имена, отличающиеся только регистром
static void Task10()
{
    int a = 5;
    int A = 6;
    Console.WriteLine(a);
    Console.WriteLine(A);
}

// Регистр в именах методов
static void Task11()
{
    // console.WriteLine("Hello");
    CompileError("error CS0103: Имя \"console\" не существует в текущем контексте.");
}

// Вывод типа через var
static void Task12()
{
    var a = 5;
    Console.WriteLine(a);

    Console.WriteLine($"проверка: тип a = {a.GetType().Name}");
    // a = "abc"; // error CS0029: Не удается неявно преобразовать тип "string" в "int".
}

// var без инициализации
static void Task13()
{
    // var a;
    // a = 5;
    CompileError("error CS0818: Неявно типизированные переменные должны быть инициализированы");
}

// var от другой переменной
static void Task14()
{
    int a = 5;
    var b = a + 5;
    Console.WriteLine(b);

    Console.WriteLine($"проверка: тип b = {b.GetType().Name}");
}
