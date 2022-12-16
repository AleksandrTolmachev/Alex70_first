from view import get_info

info = get_info()

def writing_txt():
    with open('Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt', 'a', encoding='utf-8') as line:
        line.write(f'{str(info[0])} // {str(info[1])} \n')

def writing_csv():
    with open('Alex70_first/Python Seminars/Homework_Sem7/phonebook.csv', 'a', encoding = 'utf-8') as line:
        line.write(f'{str(info[0])} // {str(info[1])} \n')
