import csv


def export_data():
    with open('Alex70_first/Python Seminars/Homework_Sem7/phonebook.csv', 'r', encoding='utf-8') as file:
        return file.read()


def import_data(data, sep=None):
    with open('Alex70_first/Python Seminars/Homework_Sem7/phonebook.csv', 'a', encoding='utf-8') as file:
        if sep == None:
            for i in data:
                file.write(f"{i}\n")
            file.write(f"\n")
        else:
            file.write(sep.join(data))
            file.write(f"\n")
