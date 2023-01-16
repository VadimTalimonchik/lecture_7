// // Задача 1
// // Собрать строчку с числамиот a до b, a <= b.
// // итеративный подход
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for(int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(1, 10));

// // рекурсия
// string NumbersRec(int a, int b)
// {
//     if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10));

//=======================
// // Задача 2
// // Собрать строчку с числамиот b до a, a >= b.
// // итеративный подход
// string NumbersFor1(int a, int b)
// {
//     string result = String.Empty;
//     for(int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// // рекурсия
// string NumbersRec1(int a, int b)
// {
//     if(a <= b) return NumbersRec1(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor1(10, 1));
// Console.WriteLine(NumbersRec1(1, 10));

//=================
// // Задача 3
// // требуется найти сумму чисел от 1 до n
// // Итеративный подход
// int SumFor(int n)
// {
//     int result = 0;
//     for(int i = 1; i <= n; i++) result += i;
//     return result;
// }
// Console.WriteLine(SumFor(10));

// // Рекурсия
// int SumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(10));

//===================
// // Задача 4
// // Факториал числа
// // Итеративный подход
// int FactorialFor(int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// Console.WriteLine(FactorialFor(10));

// // Рекурсивный подход
// int FactorialRec(int n)
// {
//     if(n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialRec(10));

//===========================
// // Задача 5
// // Возведение числа а в натуральную степень n
// // Итеративный подход
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// Console.WriteLine(PowerFor(2, 10));

// // Итеративный подход
// int PowerRec(int a, int n)
// {
//     // return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if(n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }
// Console.WriteLine(PowerRec(2, 10));

// // Применение формул для возведения в стwwепень
// int PowerRecMath(int a, int n)
// {
//     if(n == 0) return 1;
//     else if(n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerRecMath(2, 10));

//==================
// // Задача 6
// // В некотором машинном алфавите имеются 4 буквы "а", "и", "с" и "в".
// // Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.
// // Итеративный подход
// char[] s = {'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for(int i = 0; i < count; i++)
// {
//     for(int j = 0; j < count; j++)
//     {
//         for(int k = 0; k < count; k++)
//         {
//             for(int l = 0; l < count; l++)
//             {
//                 for(int m = 0; m < count; m++)
//                 {
//                     Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }
// }

// // Рекурсивный подход
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for(int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[5]);

//========================
// // Задача 7
// // Алгоритм обхода директории
// // Итеративный подход
// string path = "D:/ПРОГРАММИРОВАНИЕ/GEEK_BRAINS/РАЗРАБОТЧИК GeekBrains/EDUCATION/C#/lectures";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for(int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// Рекурсивный подход
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for(int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"D:\ПРОГРАММИРОВАНИЕ\GEEK_BRAINS\РАЗРАБОТЧИК GeekBrains\EDUCATION\C#\lectures";
CatalogInfo(path);