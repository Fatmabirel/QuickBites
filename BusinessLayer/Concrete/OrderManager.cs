using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int ActiveOrderCount()
        {
            return _orderDal.ActiveOrderCount();
        }

        public void Add(Order entity)
        {
            _orderDal.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public decimal LastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public int PassiveOrderCount()
        {
            return _orderDal.PassiveOrderCount();
        }

        public int TotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        public void Update(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
