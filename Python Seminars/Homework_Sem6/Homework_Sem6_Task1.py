# Задача 1 (Семинар 3 Задача 1). Задайте список из нескольких чисел. 
# Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

# import random
# n = int(input('Введите число N - количество элементов списка: '))
# randList = []
# for i in range(n):
#     randList.append(random.randint(0, n))
# print(randList)
# summ = 0
# for i in range(0, len(randList)):
#     if i % 2 != 0:
#         summ += randList[i]
# print(f'Сумма элементов на нечётных позициях равна: {summ}')

import random
n = int(input('Введите число N - количество элементов списка: '))
randList = ([random.randint(0, 10) for i in range(n)])
print(randList)
summ = sum([randList[i] for i in range(0, len(randList)) if i % 2 != 0])
print(f'Сумма элементов на нечётных позициях равна: {summ}')