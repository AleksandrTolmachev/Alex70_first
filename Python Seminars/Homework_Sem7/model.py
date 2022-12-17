def search_data(data, base):
    base = base.split('\n')
    flag = True
    results = []
    for i in base:
        if data in i:
            flag = False
            results.append(i)
    if flag:
        results.append(f'Контакт {data} не найден!')
    return results
