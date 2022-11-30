# Задача 5. Реализуйте алгоритм перемешивания списка.

from random import randint
from random import shuffle
import random
n = int(input('Введите число N - границы списка: '))
randList = []
for i in range(n):
    randList.append(random.randint(0, n))
print(f'Заданный список элементов: {randList}')
random.shuffle(randList)
print(f'Вывод перемешанного списка: {randList}')
