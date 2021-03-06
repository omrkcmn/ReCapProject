﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<CarDetailDto> GetUserDetails();
        List<OperationClaim> GetClaims(User user);
    }
}
