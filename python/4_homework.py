import polynom as poly
import random as rng
import math
file1 = 'poly1.txt'
file2 = 'poly2.txt'
res = 'answer.txt'

def pi_calc(approx, pow):
    elem = (-1)**(pow + 1) / ((2*pow+1) * math.exp((pow) * math.log(3)))
    pow = pow + 1
    elem2 = (-1)**(pow + 1) / ((2 * pow + 1) * math.exp((pow) * math.log(3)))
    if abs(elem - elem2) < approx:
        return elem
    else:
        return elem + pi_calc(approx,pow)


print("\033[H\033[J")     
approx = '0.000001'
app_pi = 12**0.5 * (1 - pi_calc(float(approx), 1))
print('Задача 1: вычисление числа Пи (метод Мадхавы)')
print("вычесленное занчение Пи: ", app_pi)
print("Точность вычисления  Пи: ", approx)
print("Округленное     math.pi: ", round(math.pi,len(approx)-2))
print('Значение числа  math.pi: ', math.pi)

#Задание 2: Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
def get_dividers(n):
    dividers = []
    i = 2
    while 1 < n:
        if n % i == 0:
            dividers.append(i)
            n = n // i
        else:
            i += 1
    return dividers            

     
num = 10101
print('\n\nЗадача2: разложение числа на простые множители')
print(f'простые множители числа {num}:  ', end='')
print(*get_dividers(num))        


#Задание 3: Задайте последовательность цифр. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
posl = '112345648295'
lst = list(filter(lambda x: posl.count(x)==1, list('0123456789')))
print(f'\n\nЗадача 3: вывести список неповторяющихся элементов в последовательности цифр\nв последовательности {posl} неповторяющиеся элементы:', lst)


# задание 4 адана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от -100 до 100)
# многочлена и записать в файл многочлен степени k
max_pow = 12
coef = {}
for i in range(0, max_pow+1):
    coef[i] = rng.randint(-100, 100)
poly_generated = poly.unparse_polynom(coef);    


# задание 5 
with open(file1, 'r', encoding='utf8') as poly_file:
    poly1 = poly_file.readline()
with open(file2, 'r', encoding='utf8') as poly_file:
    poly2 = poly_file.readline()

coef1 = poly.parse_polynom(poly1);
coef2 = poly.parse_polynom(poly2);
fin_coef = (poly.sum_polynum(coef1, coef2))

with open(res, 'w', encoding='utf8') as poly_file:
    poly_file.write(f'степень k={max_pow}, сгенерированный многочлен: \n')
    poly_file.write(poly_generated)
    poly_file.write(f'\nсумма многочленов из файлов {file1} и {file2} \n')
    poly_file.write(poly.unparse_polynom(fin_coef))

print(f'\n\nЗадание4, 5: результат помещен в файл {res}')    