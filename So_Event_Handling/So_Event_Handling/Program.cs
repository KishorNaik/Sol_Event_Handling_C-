using System;

namespace So_Event_Handling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var userModel = new UserModel()
            {
                FullName = "Kishor Naik",
                EmailId = "kishor.naik011.net@gmail.com"
            };

            var userContextObj = new UserContext(new UserRepository());
            userContextObj.EventDemo1(userModel);

            userContextObj.EventDemo2(userModel);
        }
    }
}