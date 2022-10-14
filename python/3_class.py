# Task 1
#  Реализуйте алгоритм задания случайных чисел без использования встроенного генератора псевдослучайных чисел.
from datetime import datetime
import time

from datetime import datetime

def get_rand_int(num):
    time = datetime.now()
    rng = time.microsecond
    return rng % num



# Task 2
#  Задайте список. Напишите программу, которая определит, присутствует ли в заданном списке строк некое число.
def find_number(list_text, num):
    index = -1;
    s = str(num)
    for i in list_text:
        if i.find(s) >= 0:  
            return True
    return False            


# Task 3
#  Напишите программу, которая определит позицию второго вхождения строки в списке либо сообщит, что её нет.
def find_second_incl(text_list, substr):
    counter = 0
    while counter < len(text_list) and text_list[counter] != substr:
        counter += 1
    while counter < len(text_list)-1:
        counter += 1
        if text_list[counter] == substr:
            return counter 
            
    return -1

# Task 4 
# Написать программу проверяющую правильность написания выражения со скобками.
# [][]{{[]}}) - правильно {[)}(){)) - неправильно *указать где ошибка
def check_brackets(brc):
    stack = []
    brc_open = {'(': ')', '[': ']', '{': '}'}

    for i in range(len(brc)):
        if brc[i] in brc_open.keys():  
            stack.append(brc[i])
        elif brc[i] in brc_open.values():
            if len(stack)>0:
                b = stack.pop()
                if brc_open[b] != brc[i]:
                    return i
            else:
                return i
    if len(stack) == 0:
        return 0
    else:
        return len(brc)


#Task 5
#  Write a function unpack() that unpacks a list of elements that can contain objects(int, str, list, tuple, dict, set) 
# within each other without any predefined depth, meaning that there can be many levels of elements contained in one another.
# Example:
# unpack([None, [1, ({2, 3}, {'foo': 'bar'})]]) == [None, 1, 2, 3, 'foo', 'bar']
# Note: you don't have to bother about the order of the elements, especially when unpacking a dict or a set. 
# Just unpack all the elements.

def unpack(lst):
    unpacked = []
    for i in lst:
        if isinstance(i, (list, set, tuple)):
            element = unpack(i)
        elif isinstance(i, dict):
            element =unpack(i.items())
        else:
            element = [i]
        unpacked += element
    return unpacked


# Task 6
# For a given list of integers, return the index of the element where the sums of the integers to the left and right of the current element are equal.
# Example:
# ints = [4, 1, 7, 9, 3, 9]
# # Since 4 + 1 + 7 = 12 and 3 + 9 = 12, the returned index would be 3
# ints = [1, 0, -1]
# # Returns None/nil/undefined/etc (depending on the language) as there
# # are no indices where the left and right sums are equal
# Here are the 2 important rules:
# The element at the index to be returned is not included in either of the sum calculations!
# Both the first and last index cannot be considered as a "midpoint" (So None for [X] and [X, X])

def find_central_point(nums):
    for i in range(len(nums)):
        if sum(nums[i+1:])==sum(nums[:i]):
            return i

# функции для тестового запуска задач:
# меняйте входные данные
#  
def test1():
    max_range_num = 100
    print('Случайные числа: ')    
    print(get_rand_int(max_range_num))


def test2():  
    my_list = ['1', '22', 'нагибатор-999', '1', '223']
    num2find = 99
    if find_number(my_list, num2find):
        print("Присутствует")
    else:
        print("число не содержится")    


def test3():
    my_list = ['1', '22', 'нагибатор-999', '1', '223']
    sub = '22'
    pos = find_second_incl(my_list, sub)
    if pos >= 0:
        print(f'подстрока {sub} второй раз встречается на позиции {pos}')
    else:
        print(f'подсторка {sub} входит в список {my_list} менее 2 раз')


def test4():
    s = '([1+1]{[3**5]}-3})'    
    print(s)
    pos = check_brackets(s)
    if pos > 0:
        st = ' '*pos
        print(f'{st}^')    
    else:
        print(f'{s} - последователность скобок правильная')


def test5():
    l = unpack([None, [1, ({2, 3}, {'foo': 'bar'})]]) 
    print(l)


def test6():
    numbers = [4, 1, 7, 9, 3, 9]            
    central = find_central_point(numbers)    
    if central is None:
        print('No central element')
    else:
        print(f'centarl element position in list {numbers} is {central}')    
test_task = {1: test1, 2: test2,3: test3, 4: test4, 5: test5, 6: test6}


# вызов функций для проверки задачи
# присвойте переменной task_number номер задачи для проверки (от 1 до 6)

task_number = 5
test_task[task_number]()