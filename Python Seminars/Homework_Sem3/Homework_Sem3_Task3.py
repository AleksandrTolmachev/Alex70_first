# Задача 3. Задайте список из вещественных чисел. Напишите программу,
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# Пример:
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19 (максимальное значение у числа 1.2 , минимальное у 10.01)

from random import uniform
n = int(input('Введите число N - количество элементов списка: '))
randList = []
for i in range(n):
    f = uniform(0, 9)
    randList.append(round(f, 2))
print(randList)
print('Дробная часть элементов списка: ')
newList = [round((randList[i] % 1), 2) for i in range(i+1)]
print(newList)

min = newList[0]
max = 0
for i in range(len(newList)):
    if max < newList[i]:
        max = newList[i]
    if min > newList[i]:
        min = newList[i]
dif = round((max - min), 2)
print(f'Разница между максимальной ({max}) и минимальной ({min}) дробными частями равна: {dif}')
