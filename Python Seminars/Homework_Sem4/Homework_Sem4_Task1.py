# Задача 1. Вычислить число Пи c заданной точностью d
# Пример:
# - при d = 0.001, π = 3.141
# - при d = 0.0001, π = 3.1415

import math
from math import pi
print(f'Число Пи: {pi}')
d = str(input('Введите число d - точность знаков после запятой: '))
num_digit = 10**int(len(d)-2)
calcPi = int(pi*num_digit)/num_digit
print(f'Число Пи с заданной точностью: {calcPi}')
