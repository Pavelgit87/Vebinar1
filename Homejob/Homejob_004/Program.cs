Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int result = number / 2; result <= number; result = result + 2)
{
 System.Console.Write(result + " ");
}
