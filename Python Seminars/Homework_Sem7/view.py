from logger import readfile
file = 'Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt'
info = readfile(file)

def search(info):
    flag = 0
    name_search = input('Введите фамилию: ')
    for name_search in info:
        if name_search in info:
            flag = 0
            print(info)
            break
        if flag == 1:
            print('Нет в справочнике!')
        search(info)

def get_info ():
    info = []
    last_name = input('Введите фамилию: ')
    info.append(last_name)
    phone_number = ''
    valid =False
    while not valid:
        try:
            phone_number = input('Введите номер телефона: ')
            if len(phone_number) != 11:
                print('В номере телефона должно быть 11 цифр.')
            else:
                phone_number = int(phone_number)
                valid = True
        except:
            print('Номер телефона должен состоять только из цифр.')
    info.append(phone_number)
    return info






# from os.path import exists

# file_name = 'Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt'

# #  чтение файла при запуске
# # def readfile(file_name):
# #     open(file_name).read().split()
# #     return info
# # readfile(file_name)
# # Просмотр всех записей справочника:
# # def scan(info):
# #     for name in  info:
# #         print(phone_number)

# # scan(info)

# # def get_info ():
# # info = []
# name = input('Введите фамилию: ')
# with open(file_name, 'r', encoding='utf-8') as file:
#     data = file.read()
# if name in file:
#     print(f'У абонента {data}')
# valid =False
# while not valid:
#     phone_number = input('Введите номер телефона: ')
#     if len(phone_number) != 11:
#         print('В номере телефона должно быть 11 цифр.')
#     else:
#         phone_number = int(phone_number)
#         valid = True

# # info.append(phone_number)
# info = (name, phone_number)
# print(info)


# # info = get_info ()

# # def writing_txt ():
# #     with open ('Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt', 'a', encoding = 'utf-8') as data:
# #         data.write(f'Фамилия: {info[0]} Номер телефона: {info[1]}')



# # valid = exists(path)
# # if not valid:
# #     writing_txt(info)
# # # Метод считывает и возвращает считанные данные с файла file_name
# # def read_text_from_file(file_name):
# #     with open(file_name, 'r', encoding='utf-8') as file:
# #         data = file.read()
# #     return data

# # # Метод позволяет записать текст в файл
# def write_text_in_file(info):
#     with open('Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt', 'a', encoding='utf-8') as file:
#         file.write(f'{str(info)} \n')
# #     return info

# write_text_in_file(info)

# # def log_result(result):
# #     with open('Alex70_first/Python Seminars/Sem_7/result.txt', 'a', encoding='utf-8') as data:
# #         data.write(f'Победитель - {str(result)}\n')



# # readfile(file_name)



# def search(info):
#     # Поиск по справочнику.
#     flag = 1
#     name_search = input('Введите фамилию: ')
#     for name_search in info:
#         if name_search in info:
#             flag = 0
#             print(f'У абонента {name_search} телефон {phone_number}')
#             break
#         if flag == 1:
#             print('Нет в справочнике!')

# search(info)