from controller import writing_csv
from controller import writing_txt
from logger import readfile
from view import search


file = 'Alex70_first/Python Seminars/Homework_Sem7/phonebook.txt'
info = readfile(file)
valid = search(info)

if not valid:
    writing_csv()
    writing_txt()
