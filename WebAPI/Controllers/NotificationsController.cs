using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.NotificationDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;
        public NotificationsController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            return Ok(_notificationService.GetAll());
        }

        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.NotificationCountByStatusFalse());
        }

        [HttpGet("GetAllNotificationsByStatusFalse")]
        public IActionResult GetAllNotificationsByStatusFalse()
        {
            return Ok(_notificationService.GetAllNotificationsByStatusFalse());
        }

        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            createNotificationDto.Status = true;
            var value = _mapper.Map<Notification>(createNotificationDto);
            _notificationService.Add(value);
            return Ok("Bildirim Eklendi");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.GetById(id);
            _notificationService.Delete(value);
            return Ok("Bildirim Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            updateNotificationDto.Status = true;
            var value = _mapper.Map<Notification>(updateNotificationDto);
            _notificationService.Update(value);
            return Ok("Bildirim Güncellendi");
        }

        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public IActionResult NotificationStatusChangeToFalse(int id)
        {
            _notificationService.NotificationStatusChangeToFalse(id);
            return Ok("Güncelleme Yapıldı");
        }

        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public IActionResult NotificationStatusChangeToTrue(int id)
        {
            _notificationService.NotificationStatusChangeToTrue(id);
            return Ok("Güncelleme Yapıldı");
        }

    }
}
