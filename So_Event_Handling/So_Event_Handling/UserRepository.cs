using System;
using System.Collections.Generic;
using System.Text;

namespace So_Event_Handling
{
    // Publisher
    public class UserRepository
    {
        // Step 1: Create an Event
        public event EventHandler<UserModel> onEmailSendHandler;

        public bool Add(UserModel userModel)
        {
            Console.WriteLine("Database Operation");

            // Step 2: Invoke Event
            onEmailSendHandler?.Invoke(this, userModel);

            return true;
        }
    }
}