string FizzBuzz(int num)

{
    if (num % 3 == 0 && num % 5 == 0)
    {
        return "FizzBuzz!";
    }

    else if (num % 3 == 0)
    {
        return "Fizz!";
    }

    else if (num % 5 == 0)
    {
        return "Buzz!";
    }

    else                                          
    {
        return "Neither fizz or buzz or even a fizzbuzz";
    }

}

Console.WriteLine("Enter a number and I'll tell you if you fizz, buzz, or fizzbuzz!");
var answer = Console.ReadLine();
var intAnswer = int.Parse(answer);
Console.WriteLine("");

Console.WriteLine(FizzBuzz(intAnswer));