using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Core
{
    public interface IBaseService
    {
        ServiceResult GetAll();
        ServiceResult GetById(int id);
    }
}
