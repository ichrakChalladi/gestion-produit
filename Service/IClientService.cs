﻿using GP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GP.ServicePattern;

namespace GP.Service
{
    public interface IClientService : IEntityService<Client>
    {
        public float GetTotalFacturePrice(int clientid);
    }

    
}
