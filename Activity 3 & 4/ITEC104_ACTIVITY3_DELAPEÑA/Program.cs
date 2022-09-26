using System;

namespace ITEC104_ACTIVITY3_DELAPEÑA
{
	class Program
	{
		public static void Main(string[] args)
		{
       //arrays and variables
       string[] emails = {"lndp1021@gmail.com", "delapenanino1@gmail.com", "lordnino.delapena@lspu.deu.ph"};
       string[] usernames = {"onin1021", "delapenanino", "oningwapo"};
       string[] passwords = {"pogiako", "odranoel19", "lordnino"};
       int index;
       //accessing arrays
       Console.Write("Index: ");
       index = Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine("Email: " + emails[index]);
       Console.WriteLine("Username: " + usernames[index]);
       Console.WriteLine("Password: " + passwords[index]);
	   Console.ReadKey();
		}
	}
}
