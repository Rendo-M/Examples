import re
import decimal

def entertext(prompt, regexp):
    while True:
        text = input(prompt)
        if re.fullmatch(regexp, text):
            return text
        else:
            print('wrong data, please repeat input')  

# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
def Tasks123():
    n = entertext('введите вещественные числа(элементы списка) через пробел: ', r'(?:-{0,1}\d{1,}\.{0,1}\d{0,} ){0,}-{0,1}\d{1,}\.{0,1}\d{0,}')
    numbers = list(map(decimal.Decimal, n.split()))
    print(f'введен список:\n', end='[')
    print(*numbers, sep=', ', end=']\n')
    print(f'сумма элементов списка на нечетных позициях: {sum(numbers[1::2])}')


# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
    nums = [numbers[i]*numbers[len(numbers)-i-1] for i in range(len(numbers) // 2 + len(numbers) % 2)]
    print(f'список произведений пар элементов: ', end='[')
    print(*nums, sep=', ', end=']\n')

# Пример:
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]
# Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
    nums = list(map(lambda x: abs(x - int(x)),numbers))
    print(f'разница между макс и мин значением дробной части элементов: {max(*nums)-min(*nums)}')


# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
def find_max_pow(x, pow):
    if x // 2**(pow+1) == 0:      
       return pow 
    else:
        return find_max_pow(x, pow+1)

def int2bin(number):
    binary_num = '';
    max_pow = find_max_pow(number, 0)
    for i in range(max_pow, -1, -1):
        binary_num += str(number // 2**i)
        number %= 2**i
    return binary_num


# Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

# Пример:

# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] 
def get_full_fib(items):
    fib =[0]
    if items > 0:
        fib.append(1)
    for i in range(2, items+1):
        fib.append(fib[i-1]+fib[i-2])
    fib = [(-1)**(i+1)*fib[i] for i in range(len(fib)-1, 0, -1)]+fib
    return fib


print("\033[H\033[J")   

# Задачи 1-3
#
Tasks123()

#Задача 4: конвертация двоичного числа:
num = int(entertext('введите целое неотрицательное число для конвертации в двоичное: ', r'\d{1,}'))
print(f'{num} = {int2bin(num)}b')  

#Задача 5: генерация последовательности фибоначи
k = int(entertext('число членов последовательности Фибоначи: ', r'\d{1,}'))
print(get_full_fib(k))