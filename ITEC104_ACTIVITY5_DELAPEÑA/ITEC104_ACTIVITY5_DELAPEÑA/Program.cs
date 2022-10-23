namespace ITEC104_ACTIVITY5_DELAPEÑA
{
    class Program
    {
        static void Main(string[] args)
        {   //display given int
            List<int> givenlist = new List<int>(new int[] { 10, 20, 35, 65, 53, 48, 5, 1 });
            foreach (int given in givenlist)
            {
                Console.Write(given + " ");
            }
            Console.WriteLine();
            //display given list of integers removing those values end with 5 
            List<int> mylist = test(new List<int>(new int[] { 10, 20, 35, 65, 53, 48, 5, 1 }));
            foreach (var num in mylist)
            {
                
                Console.Write(num.ToString() + " ");
                
            }
            Console.ReadKey();
        }
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 != 5).ToList();
        }
    }
}
