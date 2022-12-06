# Задача 5. Даны два файла, в каждом из которых находится запись многочлена. 
# Задача - сформировать файл, содержащий сумму многочленов.
# В file1.txt :
# 2*x**2 + 4*x + 5
# В file2.txt:
# 4*x**2 + 1*x + 4
# Результирующий файл:
# 6*x**2 + 5*x + 9

import sympy
x = sympy.symbols('x')

with open('file1.txt', 'w') as file:
    file.write('2*x**2 + 4*x + 5')
with open('file2.txt', 'w') as file:
    file.write('4*x**2 + 1*x + 4')

with open('file1.txt','r') as file:
    poly1 = file.readline()

with open('file2.txt','r') as file:
    poly2 = file.readline()

print(f'Первый многочлен: {poly1}')
print(f'Второй многочлен: {poly2}')

sum_poly = sympy.simplify(f'{poly1} + {poly2}')
print(f'Сумма многочленов: {sum_poly}')

with open('sum_poly.txt', 'w') as file:
    file.write(f'{sum_poly}')