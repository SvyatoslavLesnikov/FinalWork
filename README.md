# FinalWork
## Создание функции
Ввожу функцию FilterStringsByLength(), которая создаст новый массив, содержащий строки из массива, введенного пользователем, длина которых меньше или равна 3 символам. Создаю переменную count, которая будет счетитать подходящие условию задачи строки, далее написал цикл for для определения нужных строк. 
string[] resultArray = new string[count] - создает результирующий массив с размером count.
Затем ввожу переменную index и идентичный цикл for.
## Ввод строк пользователем
Программа запрашивает у пользователя ввести строки массива.
string input = Console.ReadLine() - читает введенную строку с клавиатуры.
string[] inputArray = input.Split(' ') - разбивает введенную пользователлем строку на массив строк.
## Вывод результата
Программа выводит результирующий массив строк. Использую цикл for для вывода элементов массива по одному, добавляя запятую и пробел кроме последнего элемента.