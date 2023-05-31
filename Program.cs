лекция3.2
• //функция которая ищет макс число
int Max(int arg1, int arg2, int arg3)
{
    //max число = arg1
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 33;
int b1 = 45;
int c1 = 2;
int a2 = 12;
int b2 = 9;
int c2 = 99;
int a3 = 56;
int b3 = 78;
int c3 = 456;

//с помощью функции находим макс число в 3 ячейках
//(в которых по 3 цифры)
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);
Console.Write(max);

//можно так
int max = Max(
          Max(a1, b1, c1), 
          Max(a2, b2, c2), 
          Max(a3, b3, c3));
Console.Write(max);

• //c массивом
//     индексы 0    1       2      3    4   5   6    7     8
int[] array = {11, 245, 367, 45, 59, 6, 75, 81, 90};

int max = Max(
          Max(array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8])
          );
Console.Write(max);

• //нахождение индекса
int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.Write(index);
    break;
  }
  index++;
  
}

• //метод рандом чисел
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
//распечатка в терминале
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; //определили массив из 10 элементов

FillArray(array); //заполнил массив
PrintArray(array); //распечатал

• //из рандом чисел находим индекс числа, который выбрали
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
          position = index;
          break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //определили массив из 10 элементов

FillArray(array); //заполнил массив
PrintArray(array); //распечатал
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);