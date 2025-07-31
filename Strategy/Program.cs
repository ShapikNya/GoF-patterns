using Strategy.Classes;

Console.WriteLine("Неотсортированный список: 8 10 2 5 1");
List<int> num = new List<int>() { 8, 10, 2, 5, 1 };

Console.WriteLine("Выберите стратегию:");
Console.WriteLine("1 - BubbleSort");
Console.WriteLine("2 - QuickSort");

int v = Convert.ToInt32(Console.ReadLine());

DataProcessor processor = new DataProcessor();
switch (v)
{
    case 1: processor.SetSortStrategy(new BubbleSortStrategy()); break;
    case 2: processor.SetSortStrategy(new QuickSortStrategy()); break;
    default: Console.WriteLine("Неверный выбор."); return;
}

var sorted = processor.Process(num);

Console.WriteLine("Результат сортировки:");
foreach (int i in sorted)
    Console.Write(i + " ");