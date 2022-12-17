from logger import import_data
from logger import export_data
from view import print_data
from view import input_data
from model import search_data


def choice_sep():
    sep = input("Введите разделитель: ")
    if sep == "":
        sep = None
    return sep


def choice_todo():
    print("Доступные операции с телефонной книгой:\n\
    1 - импорт;\n\
    2 - поиск контакта.")
    num = input("Введите цифру: ")
    if num == '1':
        sep = choice_sep()
        contact = input_data()
        import_data(contact, sep)
    elif num == '2':
        word = input("Введите данные для поиска: ")
        base = export_data()
        results = search_data(word, base)
        print_data(results)
