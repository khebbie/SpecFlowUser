using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using FlexFlowUser.Controllers;
using FlexFlowUserDomain;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FlexFlowSpecs
{
    [Binding]
    public class ManageUsersStepDefinition
    {
        private UsersViewModel usersViewModel;

        [Given(@"I have users named (.*)")]
        public void GivenIHaveUsersNamedGeorgeMary(string users)
        {
            var userRepository = new UserRepository();
            foreach (var s in users.Split(','))
            {
                userRepository.AddUser(new User { Name = s});  
            }
        }

        [When(@"I go to the list of users")]
        public void WhenIGoToTheListOfUsers()
        {
            var controller = new UserController();
            var result = (ViewResult)controller.Index();
            usersViewModel = result.ViewData.Model as UsersViewModel;
        }

        [Then(@"I should see (.*)")]
        public void ThenIShouldSee(string user)
        {
            bool userFound = false;
            foreach (var model in usersViewModel.users)
            {
                if(model.Name.Equals(user))
                    userFound = true;
            }
            Assert.That(userFound, Is.True);
        }
    }
}
