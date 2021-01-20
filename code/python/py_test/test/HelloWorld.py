import math
"""
* my first comment
* with many lines
"""

def fakultaet_rekursiv(n):
    if n == 1:
        return 1
    else:
        return n * fakultaet_rekursiv(n - 1)


def pythagoras(a, b):
    return math.sqrt(a*a+b*b)

def main():
    for x in range(6):
        print ("Hallo Welt: " + str(x))
    print(str(pythagoras(3, 5)))

main()
n = int(input("Zahl zwischen 1 und 10: "))
y = fakultaet_rekursiv(n)
print("Fakultät von " + str(n) + " = " + str(y))
print(f"Fakultät von {n} = {y}")


