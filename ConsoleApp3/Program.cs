int a = 2;

int b = a - 3;

Console.WriteLine(b);

int c = a + 1;

a = b + a - c;

c = c - (b + a);

b = b + a - 1;

int x = a + b + c;