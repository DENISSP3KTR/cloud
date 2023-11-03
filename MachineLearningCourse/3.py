import numpy as np


def f(x):
    return 2 / (1 + np.exp(-x)) - 1


def fs(x):
    return 0.5 * (1 + f(x)) * (1 - f(x))


def forward(w, arr):
    return np.dot(w, arr)


def Out_Array(w, arr):
    return np.array([f(x) for x in forward(w, arr)])


w1 = np.array([[-0.2, 0.3, -0.4], [0.1, -0.3, -0.4]])
w2 = np.array([[0.2, 0.3], [-0.1, 0.2], [-0.4, 0.3]])
w3 = np.array([0.3, -0.1, -0.4])
h = 0.01
n = 10000


def slay(w, delta, out):
    return w - h * delta * out


def backprop(a):
    c = len(a)
    for k in range(n):
        x = a[np.random.randint(0, c)]
        o1 = Out_Array(w1, x[0:3])
        o2 = Out_Array(w2, o1)
        y = f(forward(w3, o2))
        eps = y - x[-1]
        delta = eps * fs(y)
        for i in range(3):
            w3[i] = slay(w3[i], delta, o2[i])

        delta2 = delta * w3 * fs(o2)
        for i in range(3):
            w2[i, :] = slay(w2[i, :], delta2[i], o1[0])

        g1 = delta2[0] * w2[0, 0] + delta2[1] * w2[1, 0] + delta2[2] * w2[2, 0]
        g2 = delta2[0] * w2[0, 1] + delta2[1] * w2[1, 1] + delta2[2] * w2[2, 1]

        delta3 = (g1 * fs(o1[0]), g2 * fs(o1[1]))
        for i in range(2):
            w1[i, :] = slay(w1[i, :], delta3[i], np.array(x[0:3]))


a = [(-1, -1, -1, -1),
     (-1, -1, 1, 1),
     (-1, 1, -1, -1),
     (-1, 1, 1, 1),
     (1, -1, -1, -1),
     (1, -1, 1, 1),
     (1, 1, -1, -1),
     (1, 1, 1, 1)]

backprop(a)

for x in a:
    o1 = Out_Array(w1, x[0:3])
    o2 = Out_Array(w2, o1)
    y = f(forward(w3, o2))
    print(f"Найденное значение: {y} => Заданное: {x[-1]}")

print('', 'W1:', w1, 'W2:', w2, 'W3:', w3, sep='\n')