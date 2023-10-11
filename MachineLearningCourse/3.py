import numpy as np
import sympy as sp
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import Axes3D


def f(x):
    return 2 / (1 + np.exp(-x)) - 1


def fs(x):
    return 0.5 * (1 + f(x)) * (1 - f(x))



a = np.matrix([[-1, -1, -1],
               [-1, -1, 1],
               [-1, 1, -1],
               [-1, 1, 1],
               [1, -1, -1],
               [1, -1, 1],
               [1, 1, -1],
               [1, 1, 1]])

d = np.array([-1, 1, -1, 1, -1, 1, -1, -1])

h = 0.01
N = 10000


