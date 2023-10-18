import math

import numpy as np
import sympy as sp
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import Axes3D


def f(x1, x2):
    return x1**2+x2**2


def fs(y1, y2):
    x1, x2 = sp.symbols('x1 x2')
    x_1 = sp.diff(f(x1, x2), x1)
    x_2 = sp.diff(f(x1, x2), x2)
    return float(x_1.subs({x1: y1, x2: y2}).evalf()), float(x_2.subs({x1: y1, x2: y2}).evalf())


def GradSpusk(x1, x2, eps, h):
    z = []
    x = []
    y = []
    i = 0
    while np.linalg.norm(fs(x1, x2)) > eps:
        x1 -= h*fs(x1, x2)[0]
        x2 -= h*fs(x1, x2)[1]
        z.append(f(x1, x2))
        x.append(x1)
        y.append(x2)
        i += 1
        print(i, x1, x2)
    return x, y, z

def Adagrad(x1, x2, eps, h):
    z = []
    x = []
    y = []
    i = 0
    G1, G2 = 0, 0
    while np.linalg.norm(fs(x1, x2)) > eps:
        G1 += fs(x1, x2)[0]**2
        G2 += fs(x1, x2)[1]**2
        x1 -= h/(math.sqrt(G1+eps)) * fs(x1, x2)[0]
        x2 -= h/(math.sqrt(G2+eps)) * fs(x1, x2)[1]
        z.append(f(x1, x2))
        x.append(x1)
        y.append(x2)
        i += 1
        print(i, x1, x2)
    return x, y, z

def rm(r1, beta, sf):
    return r1 * beta + (1-beta)*sf

def RM(r1, beta, i):
    return r1/(1-beta**(i+1))

def Adam(x1, x2, eps, h):
    z = []
    x = []
    y = []
    i = 0
    r1 = 0
    r2 = 0
    m1 = 0
    m2 = 0
    beta1 = 0.9
    beta2 = 0.999
    while np.linalg.norm(fs(x1, x2)) > eps:
        r1 = rm(r1, beta2, fs(x1, x2)[0]**2)
        r2 = rm(r2, beta2, fs(x1, x2)[1]**2)
        m1 = rm(m1, beta1, fs(x1, x2)[0])
        m2 = rm(m2, beta1, fs(x1, x2)[1])
        R1 = RM(r1, beta2, i)
        R2 = RM(r2, beta2, i)
        M1 = RM(m1, beta1, i)
        M2 = RM(m2, beta1, i)
        x1 -= (h*M1)/(np.sqrt(R1+eps))
        x2 -= (h*M2)/(np.sqrt(R2+eps))
        z.append(f(x1, x2))
        x.append(x1)
        y.append(x2)
        print(i, x1, x2)
        i += 1
    return x, y, z



eps = 0.001
h = 0.01
x, y, z = Adagrad(1, 2, eps, h)
x2, y2, z2 = GradSpusk(1, 2, eps, h)
x3, y3, z3 = Adam(1, 2, eps, h)

#
x_1 = np.linspace(-2, 2, 100)
x_2 = np.linspace(-2, 2, 100)
X1, X2 = np.meshgrid(x_1, x_2)

Z = f(X1, X2)

fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')

ax.plot_surface(X1, X2, Z, color='b', alpha=0.3)
ax.plot(x, y, z, label='Gradient Descent', marker='o', color='r')
ax.plot(x2, y2, z2, label='Gradient Descent', marker='o', color='g')
ax.plot(x3, y3, z3, label='Gradient Descent', marker='o', color='b')

ax.set_xlabel('X1')
ax.set_ylabel('X2')
ax.set_zlabel('Z')

plt.show()

# 79132