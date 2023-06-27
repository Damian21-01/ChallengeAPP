int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int total0 = 0;
int total1 = 0;
int total2 = 0; 
int total3 = 0;
int total4 = 0;
int total5 = 0;
int total6 = 0;
int total7 = 0;
int total8 = 0;
int total9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        total0++;
    }
    else if (letter == '1')
    {
        total1++;
    }
    else if (letter == '2')
    {
        total2++;
    }
    else if (letter == '3')
    {
        total3++;
    }
    else if (letter == '4')
    {
        total4++;
    }
    else if (letter == '5')
    {
        total5++;
    }
    else if (letter == '6')
    {
        total6++;
    }
    else if (letter == '7')
    {
        total7++;
    }
    else if (letter == '8')
    {
        total8++;
    }
    else if (letter == '9')
    {
        total9++;
    }

}
Console.WriteLine("Wyniki dla liczby: " + number);
Console.WriteLine("0=> " + total0);
Console.WriteLine("1=> " + total1);
Console.WriteLine("2=> " + total2);
Console.WriteLine("3=> " + total3);
Console.WriteLine("4=> " + total4);
Console.WriteLine("5=> " + total5);
Console.WriteLine("6=> " + total6);
Console.WriteLine("7=> " + total7);
Console.WriteLine("8=> " + total8);
Console.WriteLine("9=> " + total9);
