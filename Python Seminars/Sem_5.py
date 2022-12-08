# Задача 1. В файле находится N натуральных чисел, записанных через пробел.
# Среди чисел не хватает одного, чтобы выполнялось условие A[i] - 1 = A[i-1]. Найдите это число.

# with open('Alex70_first/Python Seminars/file_sem005.txt', 'r') as f:
#     lst = f.readline().split()
#     print(lst)
#     lst.sort()
#     lst = list(map(int, lst))
#     print(lst)
# for i in range(1, len(lst)):
#     if lst[i] - 1 != lst[i - 1]:
#         print(lst[i] - 1)

# Задача 2. Дан список чисел. Создайте список, в который попадают числа,
# описываемые возрастающую последовательность. Порядок элементов менять нельзя.
# Пример:
# [1, 5, 2, 3, 4, 6, 1, 7] => [1, 2, 3] или [1, 7] или [1, 6, 7] и т.д.

# init_lst = [1, 5, 2, 3, 4, 6, 1, 7]
# print(init_lst)
# lst = []
# for j in range(len(init_lst)):
#     res_lst = []
#     res_lst.append(init_lst[j])
#     for i in range(j, len(init_lst)):
#         if init_lst[i] > res_lst[-1]:
#             res_lst.append(init_lst[i])
#     if len(res_lst) < 2:
#         res_lst = []
#     lst.append(res_lst)
#     lst2 = [lst3 for lst3 in lst if len(lst3) > 1]
# print(lst2)

# n = [1, 5, 2, 3, 4, 6, 1, 7]  # для последовательностей, начиная с 1-го элемента
# a = []
# h = 0
# for i in range(0, len(n)):
#     if n[i] > h:
#         h = n[i]
#         a.append(h)
#         print(a)

# Задача 3. Напишите программу, удаляющую из текста все слова, содержащие "абв".

text = '''абвгд гдежз жзе абв ыопыпт'''     
word = 'абв'     
lst = text.split()     
new_lst = [i for i in lst if word not in i]
print(text)     
new_text = ' '.join(new_lst)     
print(new_text)

# То же, только сокращённо, через lambda:
# del_st = lambda x, y: " ".join([i for i in x.split() if y not in i])
# print('абвгд гдежз жзе абв ыопыпт')
# print(del_st('абвгд гдежз жзе абв ыопыпт', 'абв'))