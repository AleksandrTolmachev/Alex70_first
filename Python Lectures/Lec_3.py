# def f(x):
#     return x**2

# g = f
# print(f(4))
# print(g(4))

# def calc(x):
#     return x+10

# print(calc(10))

# def calc1(x):
#     return x+10

# print(calc1(10))

# def calc2(x):
#     return x*10

# print(calc2(10))

# def math(op, x):
#     print(op(x))

# math(calc2, 10)
# math(calc1, 10)

# def sum(x, y):
#     return x+y

# sum = lambda x, y:x+y

# def mylt(x, y):
#     return x*y


# def calc(op, a, b):
#     print(op(a, b))
# return op(a, b)


# calc(sum, 4, 5)
# calc(lambda x, y: x+y, 4, 5)


# def sum(x):
#     return x+10
# def mult(x):
#     return x**2
# sum(mult(2))

# def sum1(x):
#  return x+22
# def mult2(x):
#  return x**3
# sum1(mult2(2))

# def sum3(x):
#  return x+242
# def mult4(x):
#  return x**5
# sum3(mult4(2))

# sum = lambda x: x+10
# mult = lambda x: x**2
# sum(mult(2))

# sum1 = lambda x: x+22
# mult2 = lambda x: x**3
# sum1(mult2(2))

# sum4 = lambda x: x+242
# mult4 = lambda x: x**5
# sum4(mult4(2))

# list = []
# for i in range(1, 101):
#     if (i % 2 == 0):
#         list.append(i)

# print(list)

# list = [i for i in range(1, 21) if i % 2 == 0]

# def f(x):
#     return x**3

# list = [(i, f(i)) for i in range(1, 21) if i % 2 == 0]
# print(list)

# path = 'file.txt'
# f = open(path, 'r')
# data = f.read() + ' '
# f.close()

# numbers = []
# while data != '':
#     space_pos = data.index(' ')
#     numbers.append(int(data[:space_pos]))
#     data = data[space_pos+1:]

# out = []
# for e in numbers:
#     if not e % 2:
#         out.append((e, e ** 2))
# print(out)

# def select(f, col):
#  return [f(x) for x in col]
# def where(f, col):
#  return [x for x in col if f(x)]
# data = '1 2 3 5 8 15 23 38'.split()
# res = select(int, data)
# res = where(lambda e: not e % 2, res)
# res = list(select(lambda e: (e, e**2), res))
# print(res)

# li = [x for x in range(1, 20)]
# print(li)
# li = list(map(lambda x:x+10, li))
# print(li)

# data = '1 2 3 5 8 15 23 38'.split()
# res = list(map(int, data))
# res = list(filter(lambda e: not e % 2, res))
# res = list(map(lambda e: (e, e**2), res))
# print(res)

# data = [x for x in range(10)]
# print(data)
# res = list(filter(lambda x: not x % 2, data))
# print(res)

# data = '1 2 3 5 8 15 23 38'.split()
# res = map(int, data)
# res = filter(lambda x: not x % 2, res)
# res = list(map(lambda x: (x, x**2), res))
# print(res)

# users = ['user1', 'user2', 'user3', 'user4', 'user5']
# ids = [4, 5, 9, 14, 7]
# salary = [111, 222, 333]

# data = list(zip(users, ids, salary))
# print(data)

users = ['user1', 'user2', 'user3', 'user4', 'user5']
data = list(enumerate(users))
print(data)