// Задача 1
// Собрать строчку с числамиот a до b, a <= b.
// итеративный подход

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(1, 10));

// рекурсия

string NumbersRec(int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));


// Задача 2
// Собрать строчку с числамиот b до a, a >= b.
// итеративный подход

string NumbersFor1(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}


// рекурсия

string NumbersRec1(int a, int b)
{
    if(a <= b) return NumbersRec1(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor1(10, 1));
Console.WriteLine(NumbersRec1(1, 10));