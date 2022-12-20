# Задача 1. Задайте строку из набора чисел. Напишите программу,
# которая покажет большее и меньшее число.
# В качестве символа-разделителя используйте пробел. 1 2 3 4 10 25 3 -> 25 1

# s = input()
# list = s.split(' ')
# print(list)
# max = 0
# min = int(list[0])
# for i in range(len(list)):
#     list[i] = int(list[i])
#     if max < list[i]:
#         max = list[i]
#     if min > list[i]:
#         min = list[i]
# print(f'Максимальное значение: {max}. Минимальное значение: {min}')

# str = [int(i) for i in input('Введите числа через пробел: ').split()]
# print(f'Большее = {max(str)}, Mеньшее = {min(str)}')

# Задача 2. Найдите корни квадратного уравнения Ax² + Bx + C = 0 двумя способами:
# 1) с помощью математических формул нахождения корней квадратного уравнения
# 2) с помощью дополнительных библиотек Python(дополнительный sympy,scipy)

# import sympy                  # вариант 1
# x = sympy.Symbol('x')
# a = float(input('a '))
# b = float(input('b '))
# c = float(input('c '))
# a = sympy.Symbol('a')
# b = sympy.Symbol('b')
# c = sympy.Symbol('c')
# expression = a * x ** 2 + b * x + c
# roots = sympy.solve(expression, dict=False)
# print(roots)


import math                 # вариант 2
a = float(input('a '))
b = float(input('b '))
c = float(input('c '))
discr = b**2 - 4*a*c
print(discr)


# x1 = (-b + (discr)**0.5) / (2 * a)
# x2 = (-b - (discr)**0.5) / (2 * a)
# print(f'x1 = {x2},  x2 = {x1}')

# Задача 3. Задайте два числа. Напишите программу, которая найдёт НОК (наименьшее общее кратное) этих двух чисел.
# *' 4 5 -> 20
# *' 6 3 -> 6
# *' 7 11 -> 77
# *' 6 8 -> 24

# a = int(input('Введите первое число: '))
# b = int(input('Введите второе число: '))
# max_val = a if a > b else b
# count = 1
# while True:
#     if (max_val // a == max_val / a) and (max_val // b == max_val / b):
#         print(max_val)
#         break
#     else:
#         count += 1
#         max_val = a if a > b else b
#         max_val *= count
