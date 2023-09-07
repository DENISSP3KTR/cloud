f = open("task2.txt", "r")
a = f.readline()
b = f.readline()
f.close()
a = a.replace("\n", "")
a = a.split(" ")
b = b.replace("\n", "")
b = b.split(" ")
c = []
for i in a:
    if i in c:
        continue
    for j in b:
        if(i==j):
            c.append(j)
            break
c.sort()
print(c)