# Модуль для ввода/вывода информации
import logger
import model
import sympy

def choose() -> str:
    """"Выбор режима работы приложения"""
    print("Доступные операции с калькулятором:\n\
    1 - решение примеров;\n\
    2 - решение уравнений;\n\
    3 - упрощение многочленов;\n\
    4 - выводит историю решений.")
    num = input("Введите цифру: ")
    return num

def choice_sep():
    """Выбор разделителя"""
    sep = input("Введите разделитель: ")
    if sep == "":
        sep = None
    return sep

def get_expr() -> str:
    """"Запрашивает у пользователя задачу"""
    expr = input("Введите задачу:  \n")
    return expr


def show_res(res: str):
    """Выводит результат"""
    print(f'Решение задачи: {res}')


def erorr_mode():
    """Выводит сообщение об ошибке выбора режима"""
    print('Некорректный вввод!')


def show_history(file: str):
    """Выводит истроию оперций"""
    print(f"\nСписок записанных решений:\n")
    for i in file:
        print(f'{i}\n')
