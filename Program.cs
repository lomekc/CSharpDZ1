
// задача 2
int a,b; 

Console.WriteLine("Input First Number ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Second Number ");
b = Convert.ToInt32(Console.ReadLine());

if ( a > b)
{
    Console.WriteLine("max number" + " " + a);

    Console.WriteLine("min number" + " " + b);
}
else
{
    Console.WriteLine("max number" + " " + b);

    Console.WriteLine("min number" + " " + a);
}


/*
// задача 4

int a,b,c, max; 

Console.WriteLine("Input First Number ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Second Number ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Third Number ");
c = Convert.ToInt32(Console.ReadLine());

{
  max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("max number" + " " + max);
}

*/

/*
//задача 6

int a; 

Console.WriteLine("Input Number ");
a = Convert.ToInt32(Console.ReadLine());


if ( a % 2 == 0)
{
    Console.Write("Yes");
}

else 
{
    Console.Write("No");
}

*/

/*
// задача 8

int a, b; 

Console.WriteLine("Input Number ");
a = Convert.ToInt32(Console.ReadLine());

b = 1;

while (b <= a)

{
    if (b%2==0)
    Console.Write(b);
    b++;
}
*/