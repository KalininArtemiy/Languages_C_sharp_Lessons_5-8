"Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами"

  Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

My solution:
1 - Firstly we'll offer our users to enter the lengs of his massive.
2 - Secodly user will enter his words into massive.
3- Thirdly we will count how many words in the first massive < 3 chars
4 - We will make a new empty massive, the lengs of the new maccive will equel the number of words in first massive with lenght < 3 chars
5 - we will full the 2 massive.