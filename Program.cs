

static void tambah (int a, int b)
{
    int c = 0;

    c = a + b;
    Console.WriteLine ($"{a} + {b} = {c}");
}

static void kurang (int a, int b)
{
    int c = 0;

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void kali (int a, int b)
{
    int c = 0;

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

static void bagi (int a, int b)
{
    int c = 0;

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");

}

tambah(10, 2);
tambah(10, 6);
kurang (10, 2);
kurang (10, 3);
kali (10, 2);
kali (10, 5);
bagi (10, 2);
bagi (10, 5);