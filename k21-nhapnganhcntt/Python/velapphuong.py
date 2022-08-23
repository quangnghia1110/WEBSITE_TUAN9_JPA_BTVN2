import tkinter as tk
import numpy as np

class App(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Bai Thuc Hanh 17")
        self.geometry('675x620')

        self.vertex = []
        self.face = []

        self.cvs_figure = tk.Canvas(self, relief = tk.SUNKEN, bg = 'white', bd = 1,
                               width = 600, height = 600)
        btn_draw_ply = tk.Button(self, text = 'Draw PLY', command = self.btn_draw_ply_click)
        self.cvs_figure.place(x = 5, y = 5)
        btn_draw_ply.place(x = 610, y = 6)

    def open_file_PLY(self):
        f = open('cube.ply', 'r')
        data = f.readlines()
        f.close()
        s = data[2][:-1]
        s = s.split()
        n_vertex = int(s[2])
        s = data[6][:-1]
        s = s.split()
        n_face = int(s[2])
        for n in range(9, 9 + n_vertex):
            s = data[n][:-1]
            s = s.split()
            temp = []
            x = float(s[0])
            y = float(s[1])
            z = float(s[2])
            temp.append(x)
            temp.append(y)
            temp.append(z)
            self.vertex.append(temp)
        for n in range(9 + n_vertex, 9 + n_vertex + n_face):
            s = data[n][:-1]
            s = s.split()
            temp = []
            for item in s:
                temp.append(int(item))
            self.face.append(temp)
    
    def btn_draw_ply_click(self):
        self.open_file_PLY()
        self.cvs_figure.delete('all')
        self.cvs_figure.update()
        W = self.cvs_figure.winfo_width() - 1
        H = self.cvs_figure.winfo_height() - 1
        xc = W // 2
        yc = H // 2
        n_face = len(self.face)
        L1 = 0.5
        phi = np.pi/4
        scale = 150
        for n in range(0, n_face):
            k = self.face[n][0]
            temp = []
            for i in range(1, k+1):
                x = self.vertex[self.face[n][i]][0]*scale
                y = self.vertex[self.face[n][i]][1]*scale
                z = self.vertex[self.face[n][i]][2]*scale
                xp = x - z*L1*np.cos(phi)
                yp = y - z*L1*np.sin(phi)
                temp.append(xc + xp)
                temp.append(yc - yp)
            x = self.vertex[self.face[n][1]][0]*scale
            y = self.vertex[self.face[n][1]][1]*scale
            z = self.vertex[self.face[n][1]][2]*scale
            xp = x - z*L1*np.cos(phi)
            yp = y - z*L1*np.sin(phi)
            temp.append(xc + xp)
            temp.append(yc - yp)
            self.cvs_figure.create_line(temp)

if __name__ == "__main__":
    app = App()
    app.mainloop()
