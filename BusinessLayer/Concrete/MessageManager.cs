using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message entity)
        {
            _messageDal.Add(entity);
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }
        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }
        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }
        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
