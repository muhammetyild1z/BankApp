using Microsoft.AspNetCore.Mvc;
using My.BankApp.Web.Data.Context;
using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Data.Interfaces;
using My.BankApp.Web.Data.Mapping;
using My.BankApp.Web.Data.Repositories;
using My.BankApp.Web.Models;
using System.Linq;

namespace My.BankApp.Web.Contrrollers
{
    public class AccountController : Controller
    { 
       // private readonly IApplicationRepostory _applicationUserRepository;
       // private readonly IApplicationMapper _applicationMapper;
       //private readonly IAccountRepository _accountRepository;
       //private readonly IAccountMapper _accountMapper;

       // public AccountController( IApplicationRepostory applicationUserRepository, IApplicationMapper applicationMapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
       // {
           
       //     _applicationUserRepository = applicationUserRepository;
       //     _applicationMapper = applicationMapper;
       //     _accountRepository = accountRepository;
       //     _accountMapper = accountMapper;
       // }

        private readonly IGenericRepository<Account> _genericRepository;
        private readonly IGenericRepository<ApplicationUser> _usergenericRepository;

        public AccountController(IGenericRepository<Account> genericRepository, IGenericRepository<ApplicationUser> usergenericRepository)
        {
            _genericRepository = genericRepository;
            _usergenericRepository = usergenericRepository;
        }

        public IActionResult Create(int id)
        {
            var user = _usergenericRepository.GetById(id);

            return View(new UserListModel
            {
                Id= id,
                Name= user.Name,
                SurName= user.SurName,
                
            });
        }
        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {

            _genericRepository.create(new Account
            {
                AccountNumber=model.AccountNumber,
                Bakance=model.Bakance,
                ApplicationUserId=model.ApplicationUserId
            });

            return RedirectToAction("Index", "Home");
        }

    }
}
