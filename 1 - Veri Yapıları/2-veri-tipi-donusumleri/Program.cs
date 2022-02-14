// Console.WriteLine("sayi 1: ");
// int sayi1 = int.Parse(Console.ReadLine());

// Console.WriteLine("sayi 2: ");
// int sayi2 = int.Parse(Console.ReadLine());

// int toplam = sayi1 + sayi2;

// Console.WriteLine($"toplam değer {toplam}");

// implicit casting (automatically): smaller type to larger
// int-long-float-double
float a = 10f;
double b = a;

float e = 10.5f;
double f = e;

//explicit casting (manually): larger type to smaller
long c = 10;
int d = (int)c;

double g = 10.6;
float j = (float)g;

double k = 10.5;
int l = (int)k;

int m = 123123;
byte n = (byte)m;

// int to string
int x = 10;
string z = x.ToString();

System.Console.WriteLine(n);