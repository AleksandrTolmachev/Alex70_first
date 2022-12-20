# Модуль для записи резуьтатов вычислений

def log_exec(expr: str, sep: str, result: str):
    """Записывает в файл результат вычислений в виде |задача -> ответ|"""
    with open('Alex70_first/Python Seminars/Homework_Sem8/calculator.csv', 'a', encoding='utf-8') as file:
        if sep == None:
            for i in expr:
                file.write(f"{i}\n")
            file.write(f"\n")
        else:
            file.write(f'{expr} {sep} {result}')
            file.write(f"\n")


def get_history() -> str:
    """"Возвращает содержимое файла с результатами вычислений"""
    with open('Alex70_first/Python Seminars/Homework_Sem8/calculator.csv', 'r', encoding='utf-8') as file:
        file = file.read().splitlines()
        return file
