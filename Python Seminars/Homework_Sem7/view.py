def input_data():
    last_name = input("Введите фамилию: ")
    phone_number = input("Введите номер контакта: ")
    return [last_name, phone_number]


def print_data(data):
    if len(data) > 0:
        print("Результат по запросу: ")
        for request in data:
            print(request)
    else:
        print("Справочник пуст!")
