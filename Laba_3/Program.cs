namespace Laba_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        // 1
        private static void Task1()
        {
            int userAge = 20;
            string userName = "Андрій";

            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }
        //2
        private static void Task2()
        {
            int number = 20;
            string userName = "Андрій"; 

            Console.WriteLine("Привіт, " + userName + "! Твій номер: " + number);
        }
        // 3
        private static void Task3()
        {
            // Оголошення змінної name та присвоєння їй значення
            string name = "Анна";

            // Оголошення змінної age та присвоєння їй значення
            int age = 25;

            // Вивід привітання в консоль з використанням двох попередьних змінних
            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age);
        }



    }
}
