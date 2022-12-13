# Задача 2 (Семинар 3 Задача 1). Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

# import random
# n = int(input('Введите число N - количество элементов списка: '))
# randList = []
# for i in range(n):
#     randList.append(random.randint(0, 9))
# print(randList)

# j = 0
# if len(randList) % 2 != 0:
#     j = len(randList)//2 + 1
# else:
#     j = len(randList)//2
# newList = [randList[i]*randList[len(randList)-i-1] for i in range(j)]
# print(f'Список произведений пар: {newList}')

import random
n = int(input('Введите число N - количество элементов списка: '))
randList = ([random.randint(0, 9) for i in range(n)])
print(randList)
j = (len(randList)//2 + 1 if len(randList) % 2 != 0 else (len(randList)//2))
# newList = [randList[i]*randList[len(randList)-i-1] for i in range(j)]

x = lambda i: randList[i] * randList[len(randList)-i-1]
newList = (x for i in range(j))

print(f'Список произведений пар: {newList}')