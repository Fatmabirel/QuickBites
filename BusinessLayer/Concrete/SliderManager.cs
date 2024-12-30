using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider entity)
        {
           _sliderDal.Add(entity);
        }

        public void Delete(Slider entity)
        {
           _sliderDal.Delete(entity);
        }

        public List<Slider> GetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider GetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void Update(Slider entity)
        {
            _sliderDal.Update(entity);
        }
    }
}
