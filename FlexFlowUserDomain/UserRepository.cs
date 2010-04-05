using System.Collections.Generic;

namespace FlexFlowUserDomain
{
    public class UserRepository
    {
        public void AddUser(User user)
        {
        }

        public List<User> GetAllUsers()
        {
            var allUsers = new List<User>
                               {
                                   new User
                                       {
                                           Name = "George"
                                       },
                                   new User
                                       {
                                           Name = "Mary"
                                       }
                               };
            return allUsers;
        }
    }
}