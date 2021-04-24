using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Log:IEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public string LogType { get; set; }
    }
}
