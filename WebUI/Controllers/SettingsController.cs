using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Dtos.IdentityDtos;

namespace WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserSettingDto userSettingDto = new UserSettingDto();
            userSettingDto.Surname = values.Surname;
            userSettingDto.Username = values.UserName;
            userSettingDto.Name = values.Name;
            userSettingDto.Mail = values.Email;
            return View(userSettingDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSettingDto userSettingDto)
        {
            if (userSettingDto.Password == userSettingDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = userSettingDto.Name;
                user.Surname = userSettingDto.Surname;
                user.Email = userSettingDto.Mail;
                user.UserName = userSettingDto.Username;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userSettingDto.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
