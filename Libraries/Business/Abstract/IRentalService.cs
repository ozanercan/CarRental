﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDto>> GetAllDto();

        IResult Add(RentalCreateDto rentalCreateDto);

        IDataResult<List<Rental>> GetListReturnDateIsNull();

        IDataResult<Rental> GetById(int id);

        IResult Update(Rental brand);

        IResult Delete(Rental brand);
    }
}