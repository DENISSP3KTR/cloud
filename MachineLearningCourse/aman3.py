import numpy as np


def f(x):
    return 2 / (1 + np.exp(-x)) - 1


def df(x):
    return 0.5 * (1 + f(x)) * (1 - f(x))


W1 = np.array([[-0.2, 0.3, -0.4], [0.1, -0.3, -0.4]])
W2 = np.array([[0.2, 0.3], [-0.1, 0.2], [-0.4, 0.3]])
W3 = np.array([0.3, -0.1, -0.4])


def forward(i):
    sum = np.dot(W1, i)
    out = np.array([f(x) for x in sum])

    sum = np.dot(W2, out)
    out2 = np.array([f(x) for x in sum])
    sum = np.dot(W3, out2)
    y = f(sum)
    return (y, out, out2)


def backprop(epoch):
    lmd = 0.01
    N = 1000000
    count = len(epoch)
    for k in range(N):
        x = epoch[np.random.randint(0, count)]
        y, out, out2 = forward(x[0:3])  # прямой проход
        e = y - x[-1]  # ошибка
        delta = e * df(y)  # градиент
        # корректировка третьего слоя
        W3[0] = W3[0] - lmd * delta * out2[0]
        W3[1] = W3[1] - lmd * delta * out2[1]
        W3[2] = W3[2] - lmd * delta * out2[2]

        delta2 = delta * W3 * df(out2)
        # корректировка второго слоя
        W2[0, :] = W2[0, :] - lmd * delta2[0] * f(out[0])
        W2[1, :] = W2[1, :] - lmd * delta2[1] * f(out[0])
        W2[2, :] = W2[2, :] - lmd * delta2[2] * f(out[0])

        g1 = delta2[0] * W2[0, 0] + delta2[1] * W2[1, 0] + delta2[2] * W2[2, 0]
        g2 = delta2[0] * W2[0, 1] + delta2[1] * W2[1, 1] + delta2[2] * W2[2, 1]
        delta11 = g1 * df(out[0])
        delta12 = g2 * df(out[1])
        # корректировка первого слоя
        W1[0, :] = W1[0, :] - lmd * delta11 * np.array(x[0:3])
        W1[1, :] = W1[1, :] - lmd * delta12 * np.array(x[0:3])


epoch = [(-1, -1, -1, -1),
         (-1, -1, 1, 1),
         (-1, 1, -1, -1),
         (-1, 1, 1, 1),
         (1, -1, -1, -1),
         (1, -1, 1, 1),
         (1, 1, -1, -1),
         (1, 1, 1, -1)]

backprop(epoch)

for x in epoch:
    y, out, out2 = forward(x[0:3])
    print(f"Найденное значение: {y} => Заданное: {x[-1]}")

print('', 'W1:', W1, 'W2:', W2, 'W3:', W3, sep='\n')