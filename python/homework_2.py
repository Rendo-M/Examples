import decimal
import random
import re

def entertext(prompt, regexp):
    while True:
        text = input(prompt)
        if re.fullmatch(regexp, text):
            return text
        else:
            print('wrong data, please repeat input')   

# 1) Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
def sum_of_digits(number):    
    number = abs(number)  
    num1 = int(number)
    num2 = number - num1
    sum = 0
    while num1 > 0:
        sum += num1 % 10
        num1 //= 10
    while num2 > 0:
        sum += int(num2*10)
        num2 = num2*10 - int(num2*10)  
    return sum        




# 2) Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
def fact_list(nums, n):
    for i in range(n-1, len(nums)):
        nums[i] *= n
    if n > 1:
        fact_list(nums, n-1)
    return nums    


# 3) Задайте список из n чисел последовательности (1 + 1/n)^n и выведите на экран их сумму.
def test3():
    num = int(entertext('введите натуральное число ', r'\d{0,}[1-9]{1}\d{0,}'))
    sequence = [((1 + 1 / i) ** i) for i in range(1, num+1)]
    print(sequence, sum(sequence))

# 4) Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных позициях. Позиции вводятся с клавиатуры .
def test4():
    num = int(entertext('введите натуральное число(длину списка) ', r'\d{0,}[1-9]{1}\d{0,}'))
    rand_list = [random.randint(-num, num) for _ in range(num)]
    f = False
    while not f:
        pos1, pos2 = map(int, entertext('введите номера элементов через пробел(нумерация начинается с 0) ', r'\d{1,} \d{1,}').split())
        f = (pos1 <= num) and (pos2 <= num)
    print(rand_list)
    print(f'произведение элементов на {pos1} и {pos2} позициях = {rand_list[pos1]*rand_list[pos2]}')    


# 5) Реализуйте алгоритм перемешивания списка.
def list_sufffle(nums):
    new_list = []
    for i in range(len(nums)-1, -1, -1):
        pos = random.randint(0,len(nums)-1)
        new_list.append(nums[pos])
        del nums[pos]
    nums = new_list    
    return nums

def test5():
    num = int(entertext('введите натуральное число(длину списка) ', r'\d{0,}[1-9]{1}\d{0,}'))
    rand_list = [random.randint(-num, num) for _ in range(num)]
    print('list before shuffle:', rand_list)
    rand_list = list_sufffle(rand_list)
    print('list after shuffle:', rand_list)


def test1():
    num = decimal.Decimal(entertext('введите вещественное число ', r'-{0,1}\d{1,}\.{0,1}\d{0,}'))
    print(f'сумма цифр числа {num} = {sum_of_digits(num)}')


def test2():
    num = int(entertext('введите натуральное число ', r'\d{0,}[1-9]{1}\d{0,}'))
    print(fact_list([1 for i in range(num)], num))


tasks =[
'1 -Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.',
'2 - Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.',
'3 - Задайте список из n чисел последовательности (1 + 1/n)^n и выведите на экран их сумму.',
'4 - Задайте список из N элементов, заполненных числами из [-N, N]. Найдите произведение элементов на позициях вводимых с клавиатуры ',
'5 - Реализуйте алгоритм перемешивания списка.',
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
i = decimal.Decimal(1)
j = decimal.Decimal(3)
print(i/j)
decimal.getcontext().prec

print(i/j)