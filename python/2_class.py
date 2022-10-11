# #1. Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
    
# #         *Пример:*
    
# #         - Для N = 5: 1, -3, 9, -27, 81

# def posl(x):
#     return (x+1) // 2


# n, x = map(int, input('enter integer number of elements and first number:').split())
# sequence = [x]
# for i in range(1, n+1):
#     x = posl(x)
#     sequence.append(x)
#     print(x, end=' ')

# #     2. Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.
    
# #         *Пример:*
    
# #         - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
# print()
# n = int(input('enter size of sequence: '))
# dct= {}
# for i in range(1,n+1):
#     dct[i] = i * 3 + 1
# print(dct)    

# #     3. Напишите программу, в которой пользователь будет задавать две строки, а программа - 
# #           определять количество вхождений одной строки в другой.

# text = input('enter text: ')
# srch = input('enter substring to search: ')
# lst = text.split(srch)
# print(f'в строке {text} подстрока {srch} содержится {len(lst)-1} раз')

# # Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

# def find_max_pow(x, pow):
#     if x // 2**(pow+1) == 0:      
#        return pow 
#     else:
#         return find_max_pow(x, pow+1)

# num = int(input('enter the number: '))
# n = num
# power = find_max_pow(num, 0)
# counter = 0;
# for i in range(power, -1, -1):
#     counter += num // 2**i
#     num %= 2**i
# print('number of 1 in binary interpritation of', n, 'is', counter)    

# 1666 uses each Roman symbol in descending order: MDCLXVI.

# Example:

# solution(1000) # should return 'M'
# Help:

# Symbol    Value
# I          1
# V          5
# X          10
# L          50
# C          100
# D          500
# M          1,000

# Remember that there can't be more than 3 identical symbols in a row.
roman = [
['I', 1],
['IV', 4],
['V', 5],
['IX', 9],
['X', 10],
['XL', 40],
['L', 50],
['XC', 90],
['C', 100],
['CD', 400],
['D', 500],
['CM', 900],
['M', 1000]]
num = 212


conv =''
for i in range(len(roman)-1, -1, -1):
    if num // roman[i][1] > 0:
        conv = conv + roman[i][0]*(num // roman[i][1])
        num = num % roman[i][1]
print(conv)