# Задача 4. Задана натуральная степень k. 
# Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена 
# и записать в файл многочлен степени k.(записать в строку)
# Пример:
# k=2 => 2*x^2 + 4*x + 5 или x^2 + 5 или 10*x**2
# k=3 => 2*x^3 + 4*x^2 + 4*x + 5

import random
from random import randint

def write_file(polyn):
    with open('file_hw_task4.txt', 'w') as data:
        data.write(polyn)

def create_abc(k):
    list = [random.randint(0,100) for i in range(k+1)]
    return list
 
def create_str(equat):
    list= equat[::-1]
    write = ''
    if len(list) < 1:
        write = 'x = 0'
    else:
        for i in range(len(list)):
            if i != len(list) - 1 and list[i] != 0 and i != len(list) - 2:
                write += f'{list[i]}x**{len(list)-i-1}'
                if list[i+1] != 0:
                    write += ' + '
            elif i == len(list) - 2 and list[i] != 0:
                write += f'{list[i]}x'
                if list[i+1] != 0:
                    write += ' + '
            elif i == len(list) - 1 and list[i] != 0:
                write += f'{list[i]}'
    return write

k = int(input("Введите натуральную степень k = "))
coeff = create_abc(k)
write_file(create_str(coeff))