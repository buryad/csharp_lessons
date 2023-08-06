int a1 = 6;
int a2 = 26;
int a3 = 72;
int b1 = 4;
int b2 = 700;
int b3 = 82;
int c1 = 48;
int c2 = 81;
int c3 = 89;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);