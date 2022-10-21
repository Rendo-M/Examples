pows = '⁰¹²³⁴⁵⁶⁷⁸⁹'

def to_pows(n):
    power = ''
    if n == 1:
        return ''
    txt = str(n)
    for i in txt:
        power+= pows[int(i)]
    return power

def from_pows(s):
    num = ''
    try:
        return int(s)
    except:
        pass    
    for i in s:
        num += str(pows.find(i))
    return int(num)

def parse_polynom(poly):
    txt = poly.replace(' ','').replace('^','').replace('*','').replace('-', '+-').split('=')
    txt = txt[0].split('+')
    coef = {}
    if 'x' not in txt[-1]:

        coef[0] = int(txt[-1])
        del txt[-1]
    print(txt)        
    for i in txt:
        if i == '':
            continue
        a, b = i.lower().split('x')
        if a == '':
            a = 1
        elif a == '-':
            a = -1
        coef[from_pows(b)] = int(a)
    return coef   

def unparse_polynom(coef):
    high_pow = max(coef.keys())
    for i in range(high_pow, -1, -1):
        coef[i] = coef.get(i,0)
    exp = ''         
    for i in range(high_pow, 0, -1):
        if coef[i] == 1:
            xp = ' + x'+ to_pows(i)
        elif coef[i] == -1:
            xp = ' - x'+ to_pows(i)
        elif coef[i] == 0:
            xp =''
        else:
            xp = ' + '+str(coef[i])+'x'+ to_pows(i)
        exp = exp + xp
    if coef[0] != 0:
        exp = exp +' + '+str(coef[0])
    exp = exp.replace('+ -', '- ') + ' = 0'
    if exp[0:2] == ' +':
        exp = exp[3:]
    else:
        exp = exp[1:]                
    return exp


def sum_polynum(coef1, coef2):
    high_pow = max(max(coef1.keys()), max(coef2.keys()))
    res_coef = {}
    for coef in range(high_pow+1):
        res_coef[coef] = coef1.get(coef, 0) + coef2.get(coef, 0) 
    return res_coef


def mul_polynum(coef, num):
    for i in coef.keys():
        coef[i] *= num
    return coef