# Курсы валют на текущую дату

import requests as rq
import xmltodict
import bs4 as bs


# def currency(curr):
#     # s = rq.get('http://www.cbr.ru/scripts/XML_daily.asp?date_req=23/07/2022')
#     s = rq.get('http://www.cbr.ru/scripts/XML_daily.asp')
#     # print(s.text)
#     dct = xmltodict.parse(s.text)['ValCurs']['Valute']
#     rate = 0.0
#     for val in dct:
#         if val['CharCode'] == curr:
#             rate = float(val["Value"].replace(',', '.')) / int(val["Nominal"])
#             print(f'Курс валюты {curr} на текущий день: \n{val["Name"]} - {rate}')
#     return rate


# rate1 = currency('USD')
# rate2 = currency('EUR')
# rate3 = currency('CNY')

html = 'https://www.banki.ru/products/currency/cash/nizhniy_novgorod/'

rq = rq.get(html)
soup = bs.BeautifulSoup(rq.text, 'html.parser')
content = soup.findall(class_='table-flex__row')
print(content)
