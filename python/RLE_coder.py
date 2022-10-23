# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных. Входные и выходные данные хранятся в отдельных текстовых файлах.
from copyreg import pickle


import pickle

def num2ch(num):
    return chr(num + 128)

def ch2num(c):
    return ord(c) - 128

def encode_string(text):
    result = ''
    count = 1
    unrepeated = ''
    
    prev = ''
    for i in text:
        if count == 127:
            if unrepeated != '':
                result = result + num2ch(-len(unrepeated)) + unrepeated
            result = result + num2ch(count) + prev
            unrepeated = ''
            count = 1
            prev = ''
        if len(unrepeated) == 127:
            result = result + num2ch(-len(unrepeated)) + unrepeated
            unrepeated = ''
        if prev == i:
            count+=1
            continue
        elif count == 1:
            unrepeated = unrepeated + prev
        else:
            if unrepeated != '':
                result = result + num2ch(-len(unrepeated)) + unrepeated
            result = result + num2ch(count) + prev
            unrepeated = ''

        prev = i        
        count = 1
    if unrepeated != '':     
        result = result + num2ch(-len(unrepeated)) + unrepeated
    result = result + num2ch(count) + prev
    return result


def decode_string(text):
    result = ''
    while len(text)> 1:
        num = ch2num(text[0])

        if num < 0:
            result = result + text[1:1-num]
            text = text[1-num:]
        else:
            result = result + text[1]*num
            text = text[2:]

    return result
                
file1 = 'in.txt'
file2 = 'out.txt'
with open(file1, 'r') as f:
    txt = f.read()    
print('текст из файла для кодирования')
print(txt)
print('длина текста: ', len(txt))
print('закодированный текст:')
txt = encode_string(txt)
print(txt)
print('длина закодированного текста:', len(txt))

with open(file2, 'rb') as f:
    txt = pickle.load(f)

print('текст после декодирования:')
print(decode_string(txt))
print('длина декодированного текста: ', len(decode_string(txt)))
with open(file2, 'wb') as f:
    pickle.dump(txt,f)
