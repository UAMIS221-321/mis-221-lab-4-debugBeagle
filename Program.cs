

using System.Globalization;
using System.Security.Cryptography;

MainMenu();



static void MainMenu()
{
    Console.Clear();
    Random random = new Random();
    int randomRows = random.Next(8, 13);
    Console.WriteLine("Choose a Pizza, \n1 plain, \n2 cheese, \n3 pepperoni, \n4 exit");
    string choice = Console.ReadLine();
    switch (choice)
    {

        case "1":
            PlainPizza(randomRows);

            break;


        case "2":
            CheesePizza(randomRows);
            break;

        case "3":
        PepperoniPizza(randomRows);
            break;

        case "4":

            System.Console.WriteLine("have a great day");
            break;

        default:
         System.Console.WriteLine("that is not a vaild answer");
         break;



    }



}
static void PlainPizza(int randomRows)
{

    for (int i = randomRows; i > 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(" * ");





        }
        Console.WriteLine();
    }

}


static void CheesePizza(int randomRows)
{

    for (int i = randomRows; i > 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (j == 0 || i == randomRows || j == i - 1 ){
            Console.Write(" * ");


            }
            
            else Console.Write(" # ");
        }
        Console.WriteLine();
    }

}


static void PepperoniPizza(int randomRows)
{
    Random randomNumGen = new Random();

    for (int i = randomRows; i > 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (j == 0 || i == randomRows || j == i - 1 ){
            Console.Write(" * ");
            


            }
            else{
                int randomPeps = randomNumGen.Next(2);
                if (randomPeps == 1){
                   Console.Write(" # ");
                }
                else Console.Write(" [] ");

            }
        }
        Console.WriteLine();
    }

}