# Лабораторная работа 3. Настройка git

Задание: https://antonc9018.github.io/uniCourse_csharp/ru/labs/basic/git/

Репозиторий — это вся папка `Soft Design` с лабораторными работами.
GitHub: https://github.com/mihaidaniel-it/soft_desing_usn

## 1. Инициализация репозитория

```
$ cd "Soft Design"
$ git init -b main
Initialized empty Git repository in .../Soft Design/.git/
```

## 2. Файл `.gitignore`

Создан стандартный для .NET [`.gitignore`](../.gitignore):

```
$ dotnet new gitignore
```

Он игнорирует временные и сгенерированные при компиляции файлы:
папки `bin/` и `obj/`, настройки IDE (`.vs/`, `.vscode/*`, `.idea/`), `.DS_Store` и т.д.

Проверка, что результаты компиляции не попадают в git:

```
$ git check-ignore -v lab02/bin lab02/obj
.gitignore:33:[Bb]in/   lab02/bin
.gitignore:34:[Oo]bj/   lab02/obj
```

## 3. Конфигурация данных в git

```
$ git config --global user.name "Daniel"
$ git config --global user.email "mihaidaniel.it@gmail.com"

$ git config --global user.name
Daniel
$ git config --global user.email
mihaidaniel.it@gmail.com
```

## 4. Коммит со всеми файлами проекта и `.gitignore`

```
$ git add -A
$ git status --short
A  .gitignore
A  README.md
A  SoftDesign.slnx
A  lab01/ManualProject/ManualProject.csproj
A  lab01/ManualProject/Program.cs
A  lab01/NewConsoleProject/NewConsoleProject.csproj
A  lab01/NewConsoleProject/Program.cs
A  lab01/README.md
$ git commit -m "lab01: установка .NET, проект вручную и через dotnet new console"
```

Папок `bin` и `obj` в коммите нет — их отсекает `.gitignore`.

## 5. Репозиторий на GitHub

Создан публичный репозиторий `soft_desing_usn`: https://github.com/mihaidaniel-it/soft_desing_usn

## 6. Связь локального репозитория с GitHub

```
$ git remote add origin https://github.com/mihaidaniel-it/soft_desing_usn.git
$ git push --set-upstream origin main
To https://github.com/mihaidaniel-it/soft_desing_usn.git
 * [new branch]      main -> main
branch 'main' set up to track 'origin/main'.

$ git remote -v
origin  https://github.com/mihaidaniel-it/soft_desing_usn.git (fetch)
origin  https://github.com/mihaidaniel-it/soft_desing_usn.git (push)
```

После этого каждая следующая лабораторная отправляется на GitHub отдельным коммитом:

```
$ git add -A
$ git commit -m "lab02: ..."
$ git push
```
