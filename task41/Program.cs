Console.Clear ();
Console.Write ("Введите кол-во чисел: ");
int n=Convert.ToInt32 (Console.ReadLine());
int b=0;
string number=string.Empty;
string posit = string.Empty;
int count =0;
int i=0;
while (i !=n)
{
    Console.Write ("Введите число: ");
    b= Convert.ToInt32 (Console.ReadLine());
    if (b>0)
    {
posit= posit+Convert.ToString (b)+ " ";
        count=count+1;
    }
    number=number+Convert.ToString (b)+ " ";
    i++;
    }
    Console.Write ("Кол-во положительных чисел: ");
    Console.WriteLine (count);
     Console.Write ("Положительные числа: ");
     Console.WriteLine (posit);
