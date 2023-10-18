import numpy as np
import sympy as sp
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import Axes3D


def f(x1, x2):
    return x1**2+x2**2
# -sp.cos(x1) * sp.cos(x2) * sp.exp(-(x1 - sp.pi) ** 2 - (x2 - sp.pi) ** 2)
# x1**2+x2**2
def fn(x1, x2):
    return -np.cos(x1) * np.cos(x2) * np.exp(-(x1 - np.pi) ** 2 - (x2 - np.pi) ** 2)

def fs(y1, y2):
    x1, x2 = sp.symbols('x1 x2')
    x_1 = sp.diff(f(x1, x2), x1)
    x_2 = sp.diff(f(x1, x2), x2)
    return (x_1.subs({x1: y1, x2: y2}).evalf(), x_2.subs({x1: y1, x2: y2}).evalf())

# def fgrad(x1, x2):
#     return (fs(x1, x2), fs(x1, x2))


def an(a0, h, i):
    return (a0[i][0] - h * fs(a0[i][0],a0[i][1])[0], a0[i][1] - h * fs(a0[i][0], a0[i][1])[1])


h = 0.01
eps = 0.001
a = [(10, 20)]
grad = fs(a[0][0], a[0][1])

x = []
y = []
z = []
i = 0
res_old = f(a[0][0], a[0][1])
res = an(a, h, i)
a.append(an(a, h, i))
res_new = f(res[0], res[1])
i += 1
while (res_old-res_new) > eps and i <= 1000:
    a.append(an(a, h, i))
    res_old = res_new
    z = np.append(z, f(a[i][0], a[i][1]))
    x = np.append(x, a[i][0])
    y = np.append(y, a[i][1])
    print(f'a{i}:{a[i]}')
    i += 1
    res_new = f(a[i][0], a[i][1])


print(f'fmin: {min(z)};')

print(x)

x1 = np.linspace(-20, 20, 100)
x2 = np.linspace(-20, 20, 100)
X1, X2 = np.meshgrid(x1, x2)

Z = f(X1, X2)

fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')

ax.plot_surface(X1, X2, Z, color='b', alpha=0.3)
ax.plot(x, y, z, label='Gradient Descent', marker='o', color='r')

ax.set_xlabel('X1')
ax.set_ylabel('X2')
ax.set_zlabel('Z')

plt.show()