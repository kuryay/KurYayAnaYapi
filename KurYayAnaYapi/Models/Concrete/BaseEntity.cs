using KurYayAnaYapi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurYayAnaYapi.Models.Concrete
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
