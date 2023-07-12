using Microsoft.AspNetCore.Mvc;
using Yıldırım.BankApp.Data.İnterfaces;
using Yıldırım.BankApp.Mapping;

namespace Yıldırım.BankApp.Controllers
{
    public class HomeController : Controller
    {
  
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        public HomeController( IApplicationUserRepository
            applicationUserRepository, IUserMapper userMapper)
        {
            
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
        }

        public IActionResult Index()
        {
          
            return View(_userMapper.MapToListOfUserList(_applicationUserRepository.GetAll()));
        }
        //DRY
       
       
    }
}
