using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WageManager : IWageService
    {
        private readonly IWageDal _wageDal;
        private readonly WageValidator _validator;

        public WageManager(IWageDal wageDal)
        {
            _wageDal = wageDal;
            _validator = new WageValidator();
        }
        public void TDelete(Wage entity)
        {
            _wageDal.Delete(entity);
        }

        public List<Wage> TGetAll()
        {
            return _wageDal.GetAll();
        }

        public Wage TGetById(int id)
        {
            return _wageDal.GetById(id);
        }

        public void TInsert(Wage entity)
        {
            var validator = new WageValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                // Hataları fırlat
                throw new ValidationException(result.Errors);
            }
            _wageDal.Insert(entity);
        }

        public void TUpdate(Wage entity)
        {
            var validator = new WageValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                // Hataları fırlat
                throw new ValidationException(result.Errors);
            }
            _wageDal.Update(entity);
        }
    }
}
