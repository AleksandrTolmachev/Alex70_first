# Задача 5. Задайте число. Составьте список чисел Фибоначчи,
# в том числе для отрицательных индексов. (Дополнительное)
# Пример:
# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

def fib(n):
    if n in [1, 2]:
        return 1
    else:
        return fib(n-1) + fib(n-2)


def reverseString(s):
    return s[::-1]


n = int(input("Введите необходимое число элементов списка Фибоначчи: "))
list_0 = [0]
list = []
for e in range(1, n + 1):
    list.append(fib(e))
revList = reverseString(list)
revListMinus = [revList[i]*(-1) for i in range(len(revList))]
joinedlist = revListMinus + list_0 + list
print(joinedlist)
