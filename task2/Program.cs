double A = -98.7;
double B = 9.23;

double max = A;
double min = B;

if (A > B) max = A;
if (A > B) min = B;
if (B > A) max = B;
if (B > A) min = A;
Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);

