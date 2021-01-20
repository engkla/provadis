a = 10
b = 50
def test():
    global a
    global b
    print("inner a={0}".format(a))
    a = 40

    print("inner b={0}".format(b))
    b = 42
    print("inner b={0}".format(b))

test()
print("outer a={0}".format(a))
print("outer b={0}".format(b))
a = 6
test()

print("outer a={0}".format(a))
print("outer b={0}".format(b))


