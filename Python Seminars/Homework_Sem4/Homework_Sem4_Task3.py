# Задача 3. Задайте последовательность чисел. Напишите программу, 
# которая выведет список неповторяющихся элементов исходной последовательности.

import random
n = int(input('Введите число N - количество элементов списка: '))
rand_list = []
for i in range(n):
    rand_list.append(random.randint(0, n))
print(rand_list)

new_list = []
[new_list.append(i) for i in rand_list if i not in new_list]
print(f"Список неповторяющихся элементов: \n{new_list}")