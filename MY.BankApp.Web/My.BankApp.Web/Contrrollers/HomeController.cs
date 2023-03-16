using Microsoft.AspNetCore.Mvc;
using My.BankApp.Web.Data.Context;
using My.BankApp.Web.Data.Interfaces;
using My.BankApp.Web.Data.Mapping;
using My.BankApp.Web.Data.Repositories;

namespace My.BankApp.Web.Contrrollers
{
    public class HomeController : Controller
    {

        private readonly IApplicationRepostory _applicationUserRepository;
        private readonly IApplicationMapper _applicationMapper;

        public HomeController(IApplicationRepostory applicationRepostory, IApplicationMapper applicationMapper)
        {

            _applicationUserRepository = applicationRepostory;
            _applicationMapper = applicationMapper;
        }



        public IActionResult Index()
        {

            return View(_applicationMapper.MapToListOfUserList(_applicationUserRepository.GetAll()));

        }
    }
}
