# Задача 1. Создайте программу для игры с конфетами человек против человека.
# Условие игры: На столе лежит 117 конфет. 
# Играют два игрока делая ход друг после друга. 
# Первый ход определяется жеребьёвкой. 
# За один ход можно забрать не более чем 28 конфет. 
# Все конфеты оппонента достаются сделавшему последний ход.

from random import randint

def input_data(name):
    n = int(input(f"{name}, введите количество конфет (от 1 до 28), которое возьмете: "))
    while n < 1 or n > 28:
        n = int(input(f"{name}, вы ошиблись, введите корректное количество конфет: "))
    return n

def final_data(name, m, summ):
    print(f"Ходил {name}, он взял конфет - {m}. На столе осталось конфет - {summ}.")

player_1 = input("Введите имя первого игрока: ")
player_2 = input("Введите имя второго игрока: ")
summ = int(input("Введите количество конфет на столе: "))

toss = randint(1,2)
"""Жеребьёвка"""
print(f'Жеребьёвка показала: {toss}')
if toss == 1:
    print(f"По условиям жребия первый ход делает {player_1}.")
else:
    print(f"По условиям жребия первый ход делает {player_2}.")

while summ > 28:
    if toss == 1:
        n = input_data(player_1)
        summ -= n
        toss = False
        final_data(player_1, n, summ)
    else:
        n = input_data(player_2)
        summ -= n
        toss = True
        final_data(player_2, n, summ)

if toss:
    print(f"Последние конфеты взял {player_1}. Поздравляем, {player_1} выиграл!")
else:
    print(f"Последние конфеты взял {player_2}. Поздравляем, {player_2} выиграл!")