import tkinter as tk

class App(tk.Tk):
    def __init__(self):
        super().__init__()
        self.spinbox = tk.Spinbox(self, from_=0, to=5)
        self.scale = tk.Scale(self, from_=0, to=5,
                              orient=tk.HORIZONTAL)
        self.btn = tk.Button(self, text="Print values",
                             command=self.print_values)
        self.spinbox.pack()
        self.scale.pack()
        self.btn.pack()

    def print_values(self):
        print("Spinbox: {}".format(self.spinbox.get()))
        print("Scale: {}".format(self.scale.get()))

if __name__ == "__main__":
    app = App()
    app.mainloop()
