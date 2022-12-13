
def log_result(result):
    with open('Alex70_first/Python Seminars/Sem_7/result.txt', 'a', encoding='utf-8') as data:
        data.write(f'Победитель - {str(result)}\n')
