# Задача 2. Напишите программу, которая принимает на вход число N
# и выдает набор произведений чисел от 1 до N.
# Пример:
# - пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

n = int(input('Введите число N: '))
prodNumb = 1
print(f'Список произведений чисел от 1 до {n} равен: ')
for i in range(n - 1):
    i = i + 1
    prodNumb = prodNumb * i
    print(prodNumb, end=', ')
i = i + 1
print(prodNumb * i, end=' ')
