f = open("task3.txt", "r")
a = f.read()
print(a)
s = set(a)
print(f"Количество уникальных слов: {len(s)}")
k = a.replace(" ", "")
print(f"Количество символов: {len(k)}")