def sestej(tab):
    vsota = tab[0]
    for el in tab[1:]:
        vsota += el
    return vsota

t = [1, 3, 8, 5]
t = "abcdef"
t = (4, 2, 3, 1)
t = ["kje", "sem", "bil", "vceraj"]
t = [1, 3, "a"]
print(sestej(t))