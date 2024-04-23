using Application.Abstracts.Repositories;
using Domain.Entities;
using Infrastructure.Concretes.Repositoryes.Base;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Concretes.Repositoryes
{
    public class SeatRepository:Repository<Seat>,ISeatRepository
    {
        public SeatRepository(CinemaPlusDbContext context):base(context)
        {
            
        }
    }
}
