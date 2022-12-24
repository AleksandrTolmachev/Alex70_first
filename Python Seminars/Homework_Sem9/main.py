# Добавить игру, реализованную ранее, с конфетами к боту.
# Условие игры: На столе лежит 117 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.

import telebot
import cfg
from random import randint

bot = telebot.TeleBot(cfg.TOKEN)
candys = dict()
player = dict()
game = dict()

"""Введите имена игроков"""

player_1 = 'Александр'
player_2 = 'Бот Джокер'


def game_over(message):
    global game
    try:
        if game[message.chat.id] and 1 <= int(message.text) <= 28:
            return True
        else:
            return False
    except KeyError:
        game[message.chat.id] = False
        if game[message.chat.id] and 1 <= int(message.text) <= 28:
            return True
        else:
            return False


"""Для старта игры набрать в боте: /Старт!"""


@bot.message_handler(commands=['Старт!'])
def begin_game(message):
    global candys, player, game
    toss = randint(1, 2)
    candys[message.chat.id] = 117
    bot.send_message(
        message.chat.id, f'Количество конфет на столе: {candys[message.chat.id]}!')
    bot.send_message(message.chat.id, f'Жеребьёвка показала: {toss}')
    game[message.chat.id] = True
    if toss == 2:
        bot.send_message(
            message.chat.id, f'По условиям жребия первый ход делает {player_2}!')
        amount = randint(1, 28)
        bot.send_message(
            message.chat.id, f'{player_2} взял конфет - {amount}!')
        candys[message.chat.id] -= amount
        bot.send_message(
            message.chat.id, f'На столе осталось конфет - {candys[message.chat.id]}!')
        bot.send_message(
            message.chat.id, f'{player_1}, ваш ход, возьмите конфеты!')
        player[message.chat.id] == player_1
    if toss == 1:
        bot.send_message(
            message.chat.id, f'По условиям жребия первый ход делает {player_1}!')
        bot.send_message(
            message.chat.id, f'{player_1}, ваш ход, возьмите конфеты!')
        player[message.chat.id] == player_1


@bot.message_handler(func=game_over)
def game_progress(message):
    global candys, player, game
    if candys[message.chat.id] > 28:
        candys[message.chat.id] -= int(message.text)
        bot.send_message(
            message.chat.id, f'На столе осталось конфет - {candys[message.chat.id]}!')
        if candys[message.chat.id] > 28:
            amount = randint(1, 28)
            bot.send_message(
                message.chat.id, f'{player_2} взял конфет - {amount}!')
            candys[message.chat.id] -= amount
            bot.send_message(
                message.chat.id, f'На столе осталось конфет - {candys[message.chat.id]}!')
            bot.send_message(
                message.chat.id, f'{player_1}, ваш ход, возьмите конфеты!')
            if candys[message.chat.id] > 28:
                candys[message.chat.id] = candys - int(message.text)
                bot.send_message(
                    message.chat.id, f'На столе осталось конфет - {candys[message.chat.id]}!')
                if candys > 28:
                    amount = randint(1, 28)
                    bot.send_message(
                        message.chat.id, f'{player_2} взял конфет - {amount}!')
                    candys[message.chat.id] -= amount
                    bot.send_message(
                        message.chat.id, f'На столе осталось конфет - {candys[message.chat.id]}!')
                    if candys <= 28:
                        bot.send_message(
                            message.chat.id, f'Победил - {player_1}!')
                        game[message.chat.id] = False
                    else:
                        bot.send_message(
                            message.chat.id, f'Победил - {player_2}!')
                        game = False
                else:
                    bot.send_message(
                        message.chat.id, f'Победил - {player_2}!')
                    game[message.chat.id] = False
            else:
                bot.send_message(message.chat.id, f'Победил - {player_1}!')
                game[message.chat.id] = False
        else:
            bot.send_message(message.chat.id, f'Победил - {player_2}!')
            game[message.chat.id] = False
    else:
        bot.send_message(message.chat.id, f'Победил - {player_1}!')
        game[message.chat.id] = False


bot.infinity_polling()
