using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILogService
    {
        IResult Add(Log log);
        IResult Delete(Log log);
        IDataResult<List<Log>> GetAll();
        IDataResult<Log> GetById(int id);
    }
}
