﻿using eTickets_Video_asp.net_core_MVCNET5.Data.Base;
using eTickets_Video_asp.net_core_MVCNET5.Models;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {

        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
