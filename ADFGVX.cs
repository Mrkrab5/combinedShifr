using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinedShifr
{
    internal class ADFGVX
    {

        public ADFGVX() 
        { 
        
        }

        static public string Decoding(string massenge, string key)
        {
            string tmpString = massenge.ToUpper(), tmpKey = key.ToUpper(), encryptString = "", result = "";

            char[,] arrayReplace = new char[6, 6] { {'Ю', 'У', 'И', 'Ч', 'К', 'Б'}, {'В', 'Г', 'Е', 'Ф', 'Ж', 'З'},
                                                    {'Й', 'А', 'Л', 'М', 'О', 'П'}, {'Р', 'Щ', 'Т', 'Я', 'Ё', 'Х'},
                                                    {'Ц', 'Н', 'Ш', 'С', 'Ы', 'Ь'}, {'Ъ', 'Э', 'Д', '-', '-', '-'} };

            Dictionary<int, char> meaning = new Dictionary<int, char>
            { {0, 'A'}, {1, 'D'}, {2, 'F'}, {3, 'G'}, {4, 'V'}, {5, 'X'} };

            Dictionary<char, int[]> dictSortKey = new Dictionary<char, int[]>();

            int countSymbol;

            //Добавление элементов в словарь dictSortKey
            for (int i = 0; i < key.Length; i++)
            {
                //Если элемента ещё нет в словаре
                if (!dictSortKey.ContainsKey(key[i]))
                {
                    //Количество символов в строке
                    countSymbol = key.Split(key[i]).Count() - 1;

                    //Создаём массив для индексов, чтобы потом по ним сортировать
                    int[] arrayCount = new int[countSymbol];

                    //Заполнение массива индексов значениями для исключения ситуации,
                    //когда индекс равен 0
                    for (int j = 0; j < countSymbol; j++)
                        arrayCount[j] = -1;

                    //Поиск повторяющихся символов и добавление их индексов
                    //в массив если их нет в словаре
                    for (int j = 0; j < countSymbol; j++)
                    {
                        //можно добавлять в массив индексов
                        bool may = true;
                        for (int k = 0; k < key.Length; k++)
                        {
                            //Если элементы равны и его индекс не находиться в массива и можно добавлять
                            if (key[k] == key[i] && !arrayCount.Contains(k) && may)
                            {
                                arrayCount[j] = k;
                                may = false;
                            }
                        }
                    }
                    //Добавление символа и индексов на которых он встречается в словарь
                    dictSortKey.Add(key[i], arrayCount);
                }
            }
            //Строка для проверки добавленных символов
            string addedSymbol = "";

            //Составление строки из уникальных символов ключа
            for (int i = 0; i < key.Length; i++)
            {
                if (!addedSymbol.Contains(key[i]))
                    addedSymbol += key[i];
            }

            //Строка для сортировки в алфавитном порядке
            addedSymbol = String.Concat(addedSymbol.OrderBy(ch => ch));

            //Формирование строки которую в дальнейшем будем шифровать
            for (int i = 0; i < massenge.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for(int k = 0; k < 6; k++)
                    {
                        if (tmpString[i] == arrayReplace[j, k])
                            encryptString += $"{meaning[j]}{meaning[k]}";
                    }
                }
            }

            //countAdded нужен для подсчёта добавленных элементов
            //row для указания количества строк в массиве с защифрованным сообщением
            int countAdded = 0, row = encryptString.Length % key.Length == 0 ? 
                encryptString.Length % key.Length : encryptString.Length % key.Length + 1;

            char[,] arrayEncrypt = new char[row, key.Length];

            //Заполнения массива эл-ми зашифрованной строки
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (countAdded < encryptString.Length)
                    {
                        arrayEncrypt[i, j] = encryptString[countAdded];
                        countAdded++;
                    }
                }
            }

            //Заполнение результата
            for (int i = 0; i < addedSymbol.Length; i++)
            {
                //Получаем количество, сколько раз встречается символ
                countSymbol = dictSortKey[addedSymbol[i]].Count();

                //Добавление в результат столбца из словаря по индексу
                for (int j = 0; j < countSymbol; j++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        //Если символ в строке не равен пустому значению
                        if (arrayEncrypt[k, dictSortKey[addedSymbol[i]][j]] != '\0')
                            result += arrayEncrypt[k, dictSortKey[addedSymbol[i]][j]];
                    }
                }
            }

            return result;
        }
    }
}
