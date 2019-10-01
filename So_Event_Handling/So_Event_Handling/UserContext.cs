using System;
using System.Collections.Generic;
using System.Text;

namespace So_Event_Handling
{
    // Subscriber
    public class UserContext
    {
        private readonly UserRepository userRepository;

        public UserContext(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void EventDemo1(UserModel userModel)
        {
            // Step 3;
            // Subscribe Event
            userRepository.onEmailSendHandler += UserRepository_onEmailSendHandler;

            userRepository.Add(userModel);

            //Unsubscribe Event
            userRepository.onEmailSendHandler -= UserRepository_onEmailSendHandler;
        }

        public void EventDemo2(UserModel userModel)
        {
            EventHandler<UserModel> eventHandler = (leSender, leUserModel) =>
            {
                // Send Mail
                Console.WriteLine(leUserModel.EmailId);
            };

            // Event Subscribe
            userRepository.onEmailSendHandler += eventHandler;

            userRepository.Add(userModel);

            //UnSubscribe Event
            userRepository.onEmailSendHandler -= eventHandler;
        }

        private void UserRepository_onEmailSendHandler(object sender, UserModel e)
        {
            // Mail Send.
            Console.WriteLine(e.EmailId);
        }
    }
}