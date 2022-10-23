from tkinter import *
from time import sleep
from random import randint
from turtle import color
from requests import delete

win = Tk()
win.title('CANDY')
win.geometry('245x275') 
my_frame = Frame()
candies = 201
max_take = 28


class Game:

    

    def __init__(self, players=0, stock=210, pack=28):
        self.players = players
        self.stock = stock
        self.pack = pack
        self.scroll = Scale(from_=self.pack, to=1)
        self.btn = Button(text='Забрать', command=self.make_move, anchor='w', padx=3, pady=3)
        self.p1_take = 0
        self.p2_take = 0
        self.last_take = 0
        self.move = randint(1,2)
        self.lbl_p1 = Label(text=f'Игрок1 забрал:    {self.p1_take}')
        self.lbl_p2 = Label(text=f'Игрок2 забрал:    {self.p2_take}')
        self.lbl_rest = Label(text=f'осталось       {self.stock} конфет')
        self.lbl_move = Label(text=f'ходит Игрок  {self.move}')
        self.lbl_win=Label(text='                                   ', fg='red')
        self.scroll.grid(row=0, column=0, rowspan=3)
        self.btn.grid(row=4, column=0)
        self.lbl_p1.grid(row=1, column=1)
        self.lbl_p2.grid(row=2, column=1)
        self.lbl_rest.grid(row=3, column=1)
        self.lbl_move.grid(row=4, column=1)
        self.lbl_win.grid(row=5, column=0, columnspan=2)
        if self.move == 2:
            self.bot_move()
            self.refresh()
            if self.stock == 0:
                self.win()
            self.next()    
            self.refresh()          

    def next(self):
        self.move = (self.move+2) % 2 + 1

    def set_pack(self, pack):
        self.pack = pack
        self.scroll.configure(from_=self.pack)

    def win(self):
        self.lbl_win.configure(text=f'Игрок{self.move} выиграл')


    def bot_move(self):
        move = 0
        if self.players == 1:
            move = self.stock % (self.pack+1)
        elif self.stock - self.pack < 0:
          move = self.stock
        if move == 0:
            move = randint(1, self.pack)
        self.stock -= move 
        if self.stock < self.pack:
                self.set_pack(self.stock)            
        self.p2_take = move

    def human_move(self):
        if self.stock - self.scroll.get() >= 0:
            self.stock -= self.scroll.get()
            if self.move == 1:
                self.p1_take = self.scroll.get()
            else:
                self.p2_take = self.scroll.get()                
            if self.stock < self.pack:
                self.set_pack(self.stock)
    

    def refresh(self):
        self.lbl_p1.configure(text=f'Игрок1 забрал: {self.p1_take}')
        self.lbl_p2.configure(text=f'Игрок2 забрал: {self.p2_take}')
        self.lbl_rest.configure(text=f'осталось {self.stock} конфет')
        self.lbl_move.configure(text=f'ходит Игрок{self.move}')

    def make_move(self):
        self.human_move()
        self.refresh()
        if self.stock == 0:
            self.win()
            return    
        self.next()    
        self.refresh()
        if self.players == 2:
            return
        self.bot_move()
        self.refresh()
        if self.stock == 0:
            self.win()
        self.next()    
        self.refresh()          









class Game_Start:
    
    def __init__(self, stock=2021, pack=28, player=2):
        self.stock = stock
        self.pack = pack
        self.players = IntVar()
        self.player = 1 
        self.rb1 = Radiobutton(text='умный бот', variable=self.players, value=1, command=self.on_change)
        self.rb2 = Radiobutton(text='(не)умный бот', variable=self.players, value=0, command=self.on_change)
        self.rb3 = Radiobutton(text='бот не нужен', variable=self.players, value=2, command=self.on_change)
        self.spin = Entry()
        self.edit = Entry()
        self.edit.insert(0, string='21')
        self.spin.insert(0, string='2021')
        self.go = Button(text='Go!', command=self.start)
        self.rb1.grid(row=6,column=0, sticky='w')
        self.rb2.grid(row=7,column=0, sticky='w')
        self.rb3.grid(row=8,column=0, sticky='w')
        self.spin.grid(row=6,column=1)
        self.edit.grid(row=7,column=1, sticky='w')
        self.go.grid(row=8,column=1)
        self.on_change()


    def start(self):
        try:
            self.game = Game(self.player, int(self.spin.get()), int(self.edit.get()))
        except:
            pass

    def on_change(self):
        self.player = self.players.get()







new_game = Game_Start(621, 17, 1)

win.mainloop()