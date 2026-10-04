# Лабораторная работа 1. Установка .NET

Задание: https://antonc9018.github.io/uniCourse_csharp/ru/labs/basic/install/

## 1. Установка .NET

Установлен .NET SDK 10.0 (LTS) официальным скриптом Microsoft, без прав администратора:

```bash
curl -sSL https://dot.net/v1/dotnet-install.sh -o dotnet-install.sh
bash dotnet-install.sh --channel LTS --install-dir "$HOME/.dotnet"
```

Чтобы `dotnet` был доступен в любой консоли, в `~/.zprofile` добавлено:

```bash
export DOTNET_ROOT="$HOME/.dotnet"
export PATH="$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools"
```

## 2. `dotnet` доступен в командной строке

```
$ which dotnet
/Users/danielmihai/.dotnet/dotnet
$ dotnet --version
10.0.401
$ dotnet --list-sdks
10.0.401 [/Users/danielmihai/.dotnet/sdk]
```

## 3. Проект, созданный вручную

Папка [ManualProject](ManualProject): файлы [ManualProject.csproj](ManualProject/ManualProject.csproj)
и [Program.cs](ManualProject/Program.cs) написаны руками, без шаблонов.

```
$ cd ManualProject
$ dotnet run
Hello from the manually created project!
```

## 4. Проект через `dotnet new console`

```
$ dotnet new console -o NewConsoleProject
Шаблон "Консольное приложение" успешно создан.
```

Шаблон создал [NewConsoleProject.csproj](NewConsoleProject/NewConsoleProject.csproj)
и [Program.cs](NewConsoleProject/Program.cs). Содержимое `.csproj` совпадает с написанным вручную.

## 5. Компиляция и запуск через `dotnet run`

```
$ cd NewConsoleProject
$ dotnet run
Hello, World!
```
