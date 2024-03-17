// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

Console.Clear();

char [,] array = {{'1', '2', '3'}, {'4', '5', '6'}};
string str = "";
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        str += array[i,j];
    }
}
Console.WriteLine(str);
