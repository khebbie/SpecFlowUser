using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.MobileControls;
using FlexFlowUserDomain;

namespace FlexFlowUser.Controllers
{
    public class UserController : Controller
    {
        private readonly UserViewModelMapper userViewModelMapper;
        public UserController()
        {
            userViewModelMapper = new UserViewModelMapper();
        }
        public ActionResult Index()
        {
            var userRepository = new UserRepository();
            List<User> allUsers = userRepository.GetAllUsers();
            UsersViewModel viewModel = userViewModelMapper.MapToViewModel(allUsers);
            return View(viewModel);
        }
    }
}