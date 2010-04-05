using System;
using System.Collections.Generic;
using AutoMapper;
using FlexFlowUserDomain;

namespace FlexFlowUser.Controllers
{
    public class UserViewModelMapper
    {
        public UserViewModelMapper()
        {
            Mapper.CreateMap<User, UserViewModel>();
        }

        public UsersViewModel MapToViewModel(IEnumerable<User> users)
        {

            var userViewModels = new List<UserViewModel>();
            foreach (User user in users)
            {
                var viewModel = Mapper.Map<User, UserViewModel>(user);
                userViewModels.Add(viewModel);
            }
            var usersModel = new UsersViewModel { users = userViewModels };
            return usersModel;
        }
    }
}