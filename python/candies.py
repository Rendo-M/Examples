from tkinter import *
from time import sleep
from random import randint
from turtle import color
from requests import delete

win = Tk()
win.title('CANDY')
win.geometry('225x285') 
candies = 2001
max_take = 28

def opponent_move():
    move = candies % (max_take+1)
    if move == 0:
        return 1
    return move

def game_ends(s):
    global my_scale
    global my_lbl3
    my_lbl3.config(text='Game ends, you ' + s, fg='red')
    my_lbl3.grid(row=13, column=1, columnspan=4, padx=1, pady=1)
 

def take_candy():
    global candies
    global my_lbl2
    global my_lbl
    get_candy = my_scale.get()
    if candies-get_candy >= 0:
        candies = candies - get_candy
        my_lbl.config(text=str(candies))
        my_lbl.grid(row=9, column=1, columnspan=4, padx=1, pady=1)
    else:
        return None
    if candies > 0:
        sleep(0.1)
        get_candy = opponent_move()
        candies = candies - get_candy
        my_lbl2.config(text='Оппонент забрал: ' + str(get_candy))
        my_lbl2.grid(row=11, column=1, columnspan=4, padx=1, pady=1)
        my_lbl = Label(text=str(candies))
        my_lbl.grid(row=9, column=1, columnspan=4, padx=1, pady=1)
        if candies == 0:
            game_ends('lose')    
    else:
        game_ends('win')
    if candies < 28:
        my_scale.configure(from_=candies)
    



my_scale = Scale(from_=28, to=1)
my_scale.grid(row=1, column=1, rowspan=2)
my_btn = Button(text='Забрать', width= 8, height=3, padx=25, command=take_candy)
my_btn.grid(row=1, column=3, rowspan=2, padx=15)
my_lbl1 = Label(text='Осталось конфет:')
my_lbl1.grid(row=7, column=1, columnspan=4, padx=1, pady=1)
my_lbl = Label(text=str(candies))
my_lbl.grid(row=9, column=1, columnspan=4, padx=1, pady=1)
my_lbl2 =Label(text='противник забрал: ')
my_lbl2.grid(row=11, column=1, columnspan=4, padx=1, pady=1)
my_lbl3 =Label(text='')
if randint(0,1):
    my_lbl4 =Label(text='  Жребий брошен:  Вы ходите первым')
else:
    my_lbl4 =Label(text='  Жребий брошен:  Вы ходите вторым')
    sleep(0.5)
    get_candy = opponent_move()
    candies = candies - get_candy
    my_lbl2.config(text='Оппонент забрал: ' + str(get_candy))
    my_lbl2.grid(row=11, column=1, columnspan=4, padx=1, pady=1)
    my_lbl = Label(text=str(candies))
    my_lbl.grid(row=9, column=1, columnspan=4, padx=1, pady=1)    
my_lbl3.grid(row=13, column=1, columnspan=4, padx=1, pady=1)    
my_lbl4.grid(row=15, column=1, columnspan=4, padx=1, pady=1)


win.mainloop()