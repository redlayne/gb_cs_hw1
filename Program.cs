void Break()
{
    Console.WriteLine("");
    Console.WriteLine(new string('*', 40));
    Console.WriteLine("");
}

void MaxNum2() // тут можно было передавать параметры в функцию снаружи, а можно было реализовать через return
{
    Console.WriteLine("Input 1st number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input 2nd number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2) Console.WriteLine("Maximum is " + num1);
    else Console.WriteLine("Maximum is " + num2);
}

void MaxNum3()
{
    int num1 = new Random().Next(0,100); // не будем мурыжить пользователя вводом
    int num2 = new Random().Next(0,100);
    int num3 = new Random().Next(0,100);
    Console.WriteLine("Our numbers are " + num1 + ", " + num2 + ", " + num3);

    int max = num1; 
    if (num2 > max) max = num2;
    if (num3 > max) max = num3; // для трех так даже короче, чем с else

    Console.WriteLine("Maximum is " + max);
}

void IsEven()
{
    Console.WriteLine("Input some number");
    int somenumber = Convert.ToInt32(Console.ReadLine());
    if (somenumber % 2 == 0) Console.WriteLine("Number is even");
    else Console.WriteLine("Number is odd");
}

void AllEvenToN()
{   
    Console.WriteLine("Input a number");
    int othernumber = Convert.ToInt32(Console.ReadLine());

    bool numisbad = true;
    while (numisbad)
    {
        if (othernumber <= 1)
        {
            Console.WriteLine("Number should be higher than 1" + "\nInput another number");
            othernumber = Convert.ToInt32(Console.ReadLine());
        } 
        else numisbad = false;
    }

    int i = 2;
    while (i <= othernumber) // конечно тут можно было проверять остаток от деления, но зачем ) складывать проще и быстрее
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}

Break();
MaxNum2(); // задача 2

Break();
MaxNum3(); // задача 4

Break();
IsEven(); // задача 6

Break();
AllEvenToN(); // задача 8

Break();