a = []
for i in range(int(input("Введите количество организаций: "))):
    a.append(input(f"Введите наименование организации {i+1}: ")+":")
    a.append('\n')
    a.append(input("Адрес организации: ")+", ")
    a.append(int(input("Контактный номер: ")))
    a.append('\n')
f = open("task1.txt", "w")
for i in a:
    f.write(i)
f.close()
r = open("task1.txt", "r")
print(r.read())
r.close()
