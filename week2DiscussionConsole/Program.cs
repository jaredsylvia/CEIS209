int loopOne = 1;
int loopTwo;
int loopThree = 3;

Console.WriteLine("Three loops:");

Console.WriteLine("While loopOne <= 10, starting at 1:");
while (loopOne <= 10)
{
    Console.WriteLine(loopOne);
    loopOne++;
}

Console.WriteLine("Counting by twos, starting at 2, using a for loop:");


for(loopTwo = 2; loopTwo <= 20; loopTwo += 2)
    Console.WriteLine(loopTwo);

Console.WriteLine("Do loop, while loopThree <= 30, count by threes, starting at 3");
do
{
    Console.WriteLine(loopThree);
    loopThree += 3;
} while (loopThree <= 30);



