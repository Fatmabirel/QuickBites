﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int ActiveCategoryCount()
        {
            return _categoryDal.ActiveCategoryCount();
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public int CategoryCount()
        {
            return _categoryDal.CategoryCount();
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public int PassiveCategoryCount()
        {
            return _categoryDal.PassiveCategoryCount();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
