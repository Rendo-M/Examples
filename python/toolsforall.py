import re

def entertext(prompt, regexp):
    while True:
        text = input(prompt)
        if re.fullmatch(regexp, text):
            return text
        else:
            print('wrong data, please repeat input')    
            