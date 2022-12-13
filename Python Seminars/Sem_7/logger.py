
def log_result(result):
    with open('result.txt', 'w', encoding='utf-8') as data:
        data.write(f'Победитель - {str(result)}\n')
