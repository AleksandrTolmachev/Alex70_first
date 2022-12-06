# Задача 2. Задайте натуральное число N. Напишите программу,
# которая составит список простых множителей числа N.
#  6 -> [2,3]
#  144 -> [2,3]

n = int(input("Введите натуральное число N: "))
list = []
i = 2
""" Первое простое число """
orig = n
while i <= n:
    if n % i == 0:
        list.append(i)
        n = n / i
        i = 2
    else:
        i = i + 1
# print(f"Число {orig} состоит из простых множителей: {list}")
new_list = []
[new_list.append(i) for i in list if i not in new_list]
print(f"Число {orig} состоит из простых множителей: {new_list}")
