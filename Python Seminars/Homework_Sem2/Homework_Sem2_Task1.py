# Задача 1. Напишите программу, которая принимает на вход вещественное число
# и показывает сумму его цифр.
# Пример:
# - 6782 -> 23
# - 0,56 -> 11

a = input('Введите вещественное число: ')
if float(a) < 0:
    a = float(a) * (-1)


def summa(a):
    sum = 0
    for i in str(a):
        if i != '.':
            sum += int(i)
    return sum


print(f'Сумма всех чисел равна: {summa(a)}')
