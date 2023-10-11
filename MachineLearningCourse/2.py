import numpy as np
import sympy as sp
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import Axes3D


def f(x1, x2):
    return -sp.cos(x1) * sp.cos(x2) * sp.exp(-(x1 - sp.pi) ** 2 - (x2 - sp.pi) ** 2).evalf()
# -sp.cos(x1) * sp.cos(x2) * sp.exp(-(x1 - sp.pi) ** 2 - (x2 - sp.pi) ** 2)
# x1**2+x2**2
def fn(x1, x2):
    return -np.cos(x1) * np.cos(x2) * np.exp(-(x1 - np.pi) ** 2 - (x2 - np.pi) ** 2)
def fs(y1, y2, a):
    x1, x2 = sp.symbols('x1 x2')
    match a:
        case 1:
            x = sp.diff(f(x1, x2), x1)
            return x.subs({x1: y1, x2: y2}).evalf()
        case 2:
            x = sp.diff(f(x1, x2), x2)
            return x.subs({x1: y1, x2: y2}).evalf()
        case _:
            x = sp.diff(f(x1, x2), x1) + sp.diff(f(x1, x2), x2)
            return x.subs({x1: y1, x2: y2}).evalf()


def fgrad(x1, x2):
    return (fs(x1, x2, 1), fs(x1, x2, 2))


def an(a0, h):
    return (a0[0] - h * fgrad(a0[0],a0[1])[0], a0[1] - h * fgrad(a0[0], a0[1])[1])


h = 0.01
a = [(1.5, 3)]

grad = fgrad(a[0][0], a[0][1])

x = []
y = []
z = []
i = 0
amin = f(a[0][0], a[0][1])
a2min = 0
a1min = 0
j = 0
while i <= 100:
    a.append(an(a[i], h))
    if amin > f(a[i][0], a[i][1]):
        a1min = a[i][0]
        a2min = a[i][1]
        amin = f(a[i][0], a[i][1])
        j = i
    z = np.append(z, f(a[i][0], a[i][1]))
    x = np.append(x, a[i][0])
    y = np.append(y, a[i][1])
    print(f'a{i}:{a[i]}')
    i += 1
print(f'fmin: {min(z)}; x1min: {a1min}, x2min: {a2min}; index minimal solve {j}')


x1 = np.linspace(-2, 5, 100)
x2 = np.linspace(-3, 10, 100)
X1, X2 = np.meshgrid(x1, x2)

Z = fn(X1, X2)

fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')

ax.plot_surface(X1, X2, Z, color='b', alpha=0.3)
ax.plot(x, y, z, label='Gradient Descent', marker='o', color='r')

ax.set_xlabel('X1')
ax.set_ylabel('X2')
ax.set_zlabel('Z')

plt.show()
