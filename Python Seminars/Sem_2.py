# Задача 1. Напишите программу, которая принимает на вход число N
# и выдаёт последовательность из N членов.
# Пример:
# - Для N = 5: 1, -3, 9, -27, 81

# n = int(input())
# for i in range(n-1):
#     print((-3) ** i, end=', ')
# print((-3) ** (i+1))

# Задача 2. Для натурального n создать словарь индекс-значение,
# состоящий из элементов последовательности 3n + 1.
# Пример:
# - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

# slov = {}
# n = int(input())
# for i in range(1, n+1):
#     slov[i] = 3 * i + 1
# print(slov)

# Задача 3. Напишите программу, в которой пользователь будет задавать две строки,
# а программа - определять количество вхождений одной строки в другой.

# str1 = input()
# str2 = input()
# count = str1.count(str2)
# print(count)

# str1 = input()
# str2 = input()
# count = 0
# while str2 in str1:
#     str1 = str1.replace(str2,'', 1)
#     count += 1
# print(count)

a = input()
b = input()
count = 0
for i in range(len(a)):
    if a[i:i+len(b)] == b:
        count += 1
print(count)
print(a.count(b))

# Создание файла file.txt и выгрузка из него данных

# with open('file.txt','r') as f:
#     a = f.read().split('\n')
# print(a)