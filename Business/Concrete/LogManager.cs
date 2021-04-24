using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class LogManager:ILogService
    {
        ILogDal _logDal;

        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }

        public IResult Add(Log log)
        {
            _logDal.Add(log);
            return new SuccessResult(Messages.LogAdded);
        }

        public IResult Delete(Log log)
        {
            _logDal.Delete(log);
            return new SuccessResult(Messages.LogDeleted);
        }

        public IDataResult<Log> GetById(int id)
        {
            return new SuccessDataResult<Log>(_logDal.Get(l => l.Id == id),Messages.LogFound);
        }

        public IDataResult<List<Log>> GetAll()
        {
            return new SuccessDataResult<List<Log>>(_logDal.GetAll(),Messages.LogsListed);
        }
    }
}
