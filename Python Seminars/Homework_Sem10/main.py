# Создать бота для вывода текущего курса валют(желательно запрос по конкретной валюте)
# /currency USD

import requests as rq
import xmltodict
import bs4 as bs
import telebot
import cfg

bot = telebot.TeleBot(cfg.TOKEN)

@bot.message_handler(func=lambda call: True)
def currency(message):    
    s = rq.get('http://www.cbr.ru/scripts/XML_daily.asp')
    dct = xmltodict.parse(s.text)['ValCurs']['Valute']
    rate = 0.0
    """Введите обозначение валюты, курс которой мы хотим узнать"""
    curr = (message.text)
    for val in dct:
        if val['CharCode'] == curr:
            rate = float(val["Value"].replace(',', '.')) / int(val["Nominal"])
            bot.send_message(message.chat.id, f'Курс валюты {curr} на текущий день: \n{val["Name"]} => {rate}')

bot.infinity_polling()