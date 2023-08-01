namespace BMIUdregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast din højde i CM");
            double height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast din vægt i KG");
            double weight = Double.Parse(Console.ReadLine());

            height /= 100;

            double bmi = (weight / (height * height));


            Console.WriteLine("Din BMI er " + bmi);

            if (bmi > 16 && bmi < 18.5)
            {
                Console.WriteLine("Du er undervætig");
            }
            else if (bmi > 18.5 && bmi < 24)
            {
                Console.WriteLine("Du er normal vægtig");
            }
            else if (bmi > 24 && bmi < 30)
            {
                Console.WriteLine("Du er over vægtig");
            }
            else if (bmi > 30 && bmi < 35)
            {
                Console.WriteLine("Du er første grads overvægtig");
            }
            else if (bmi > 35 && bmi < 40)
            {
                Console.WriteLine("Du er anden grads overvægtig");
            }
            else if (bmi < 40)
            {
                Console.WriteLine("Du er tredje grads overvægtig");
            }
        }
    }
}