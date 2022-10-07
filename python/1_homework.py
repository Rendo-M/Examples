# 1 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

def is_day_of(num):
    if 0 < num < 6:
        return 'рабочий день'
    elif 5< num < 8:
        return 'выходной день'
    return 'не день недели'       


# 2 Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.
def test_set(pred):
 return  (not (pred[0] or pred[1] or pred[2])) == ((not pred[0]) and (not pred[1]) and (not pred[2])) 


def predicate_table():
    predicate = [];
    for i in range(2):
        for j in range(2):
            for k in range(2):
                predicate.append([bool(i),bool(j), bool(k)])
    return predicate


def print_predicts(pred):
    print('|x\t|y\t|z\t|result\t|')
    for i in pred:
        print(end='|')
        print(*i, sep='\t|', end='\t|')
        print(test_set(i), end='\t|\n')


# 3 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).
def check_quatter(x,y):
    if x > 0 and y > 0: 
        return 1
    elif x < 0 and y > 0:
        return 2
    elif x < 0 and y < 0:
        return 3
    elif x > 0 and y < 0:
        return 4   
    elif x != 0:
        return 'точка на оси y'
    elif y != 0:
        return 'точка на оси x'
    return ('Это начало координат')


# 4 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
def coord_for_quater(quatter):
    quatters = {1: 'x > 0 , y > 0', 2: 'x < 0 , y > 0', 3: 'x < 0 , y < 0', 4: 'x > 0 , y < 0'}
    return quatters.get(quatter)

#  5 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
def len_2d(x1, y1, x2, y2):
    return ((x1-x2)**2 + (y1-y2)**2)**0.5


def test1():
    print(is_day_of(int(input('номер дня: '))))
    
def test2():
    pred = predicate_table()
    print_predicts(pred)

def test3():
    print(check_quatter(*map(int,input('координаты x y через пробел: ').split())))

def test4():
    print(coord_for_quater(int(input('введите номер четверти: '))))

def test5():
    print(len_2d(*map(int,input('координаты (x1 y1) (x2 y2) через пробел: ').split())))

tasks =[
'1 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.',
'2 - Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.',
'3 - Напишите программу, которая принимает на вход координаты точки и выдаёт номер четверти, в которой она находится (или на какой оси)',
'4 - Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).',
'5 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.',
'любой другой символ - выход'
]
tests ={'1': test1, '2': test2, '3': test3, '4': test4, '5': test5}

def test_all():
    print("\033[H\033[J")
    print('введите номер задачи для запуска')
    print(*tasks, sep='\n')
    answer = input()
    while answer in '12345':
        tests[answer]()
        input('press enter to continue...')
        print("\033[H\033[J")
        print('введите номер задачи для запуска')
        print(*tasks, sep='\n')
        answer = input()

test_all();    