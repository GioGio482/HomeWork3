// 1.

Console.Write("Введите пятизначное число: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    int numberLen = (int)Math.Log10(Math.Abs(number)) + 1;
    if (numberLen != 5 ) Console.WriteLine("Это не пятизначное число");
}
else Console.WriteLine("Введено не целое число");

int a = 0;
int b = number;

for(int i=5; i != 0; i--) 
{
    a = a * 10;
    a = a + (b % 10);
    b = b / 10;
}

if (number != a)
{
    Console.WriteLine($"Введеное число  {number} не является палиндромом");
}
else Console.WriteLine($"Введеное число  {number} является палиндромом");


// 2.

int[] arrayA = new int[3];
int[] arrayB = new int[3];

void coordInput(string a) // метод заполнения массивов координат точек, аргумент a - имя точки, A или B
{
    Console.Write($"Введите значение X для точки {a} : ");
    if(int.TryParse(Console.ReadLine(), out int x))
    {
        switch(a)
        {
            case "A":
                arrayA[0] = x;
                break;
            case "B":
                arrayB[0] = x;
                break;
            default:
                Console.WriteLine("Неверное значение, введите 'A' или 'B' ");
                break;
        }
        
    }
    else Console.WriteLine("Введено не целое число");

    Console.Write($"Введите значение Y для точки {a} : ");
    if(int.TryParse(Console.ReadLine(), out int y))
    {
        switch(a)
        {
            case "A":
                arrayA[1] = y;
                break;
            case "B":
                arrayB[1] = y;
                break;
            default:
                Console.WriteLine("Неверное значение, введите 'A' или 'B' ");
                break;
        }
        
    }
    else Console.WriteLine("Введено не целое число");
    
    Console.Write($"Введите значение Z для точки {a} : ");
    if(int.TryParse(Console.ReadLine(), out int z))
    {
        switch(a)
        {
            case "A":
                arrayA[2] = z;
                break;
            case "B":
                arrayB[2] = z;
                break;
            default:
                Console.WriteLine("Неверное значение, введите 'A' или 'B' ");
                break;
        }
        
    }
    else Console.WriteLine("Введено не целое число");

}

coordInput("A");
coordInput("B");

Console.WriteLine($"Введены координаты XYZ для точки A: {arrayA[0]} , {arrayA[1]} , {arrayA[2]}");
Console.WriteLine($"Введены координаты XYZ для точки B: {arrayB[0]} , {arrayB[1]} , {arrayB[2]}");

double distance = Math.Sqrt(Math.Pow((arrayA[0]-arrayB[0]),2)+Math.Pow((arrayA[1]-arrayB[1]),2)+Math.Pow((arrayA[2]-arrayB[2]),2));
distance=Math.Round(distance, 2);

Console.WriteLine($"Расстояние между указанными точками будет равно {distance}");


// 3.


Console.Write("Введите целое число: ");

String a ="| ";

if(int.TryParse(Console.ReadLine(), out int number))
{
    for(int i = 1; i != number + 1; i++)
    {
        a = a + Math.Pow(i, 3) + " | ";
    }
}
else Console.WriteLine("Введено не целое число");

Console.WriteLine($"Ряд значений кубов целых чисел от 1 до {number}:");
Console.WriteLine(a);