using System;

float i = 1;
float sum1 = -1, sum2 = 0;
while (sum1 != sum2)
{
    sum1 = sum2;
    sum2 += 1 / (i*(i+1)*(i+2));
    i++;
} 
Console.WriteLine("float:" + sum2);

double j = 1;
double s1 = -1, s2 = 0;
while (s1 != s2)
{
    s1 = s2;
    s2 += 1 / (j * (j + 1) * (j + 2));
    j++;
} 
Console.WriteLine("double:" + s2);
