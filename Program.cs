//Дано список з чисел та індекс елемента в списку k. 
//Видаліть зі списку елемент з індексом k, зсунувши вгору всі елементи, 
//що стоять нижче елемента з індексом k
int n;
var rd = new Random();
var numbers = new List<int>();
Console.WriteLine("введіть кількість чисел в списку");
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    numbers.Add(rd.Next(0,50));
}
Build(numbers);
Console.WriteLine();
Console.WriteLine("введіть index в списку який треба видалити");
int ind = int.Parse(Console.ReadLine());
numbers.RemoveAt(ind-1);
Build(numbers);

static void Build(List<int> arrs)
{
    foreach (var arr in arrs)
    {
        Console.Write(arr + " ");
    }
}


