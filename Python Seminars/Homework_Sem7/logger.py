
def readfile(file):
    file = 'Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt'
    with open(file, 'r', encoding='utf-8') as file:
        data = file.read()
    return data
