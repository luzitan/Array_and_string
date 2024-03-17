// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

// Console.Clear();

// char [,] array = {{'1', '2', '3'}, {'4', '5', '6'}};
// string str = "";
// for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++){
//         str += array[i,j];
//     }
// }
// Console.WriteLine(str);


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные. 

// string str = "LuZiTANo";
// Console.Write(str.ToLower());

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "шалаш";
bool flag = true;
for (int i = 0; i < str.Length/2; i++){
    if (str[i] != str[str.Length - 1 - i]){
        flag = false;
    }
}
if (flag){
    Console.Write("Да");
}
else{
    Console.Write("Нет");
}