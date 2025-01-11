using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.MessageDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        public MessagesController(IMessageService aboutService, IMapper mapper)
        {
            _messageService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.GetAll();
            return Ok(_mapper.Map<List<ResultMessageDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            var value = _mapper.Map<Message>(createMessageDto);
            _messageService.Add(value);
            return Ok("Mesaj Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.GetById(id);
            _messageService.Delete(value);
            return Ok("Mesaj Silindi");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _messageService.Update(value);
            return Ok("Mesaj Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.GetById(id);
            return Ok(_mapper.Map<GetMessageDto>(value));
        }
    }
}
