using System.ComponentModel.Design;

namespace Discount__Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Product Price");
            double firstprice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Your Second Product Price");
            double secondprice = Convert.ToDouble(Console.ReadLine());

            double discountPrice;

            if (firstprice > secondprice)
            {
                discountPrice = firstprice * 0.7;
            }
            else
            {
                discountPrice = secondprice * 0.7;
            }

            Console.WriteLine("Discount Price:" + discountPrice);

            Console.WriteLine("Do You Wamt To Buy A Third Product? (Yes/No)");
            string useranswer = Console.ReadLine();

            if (useranswer == "Yes")
            {
                Console.WriteLine("Please Enter Your Third Product Price");
                double thirdprice = Convert.ToDouble(Console.ReadLine());
                double discount3 = thirdprice * 0.5;
                Console.WriteLine("Discount Price Of The Third Product:" + discount3);
            }

            if (useranswer == "No")
            {
                Console.WriteLine("Program İs Closing");

            }
        }
    }
}


