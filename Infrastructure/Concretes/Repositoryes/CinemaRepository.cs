using Application.Abstracts.Repositories;
using Application.Abstracts.Repositories.Base;
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
    public class CinemaRepository:Repository<Cinema>,ICinemaRepository
    {
        public CinemaRepository(CinemaPlusDbContext context) : base(context) { }
    }

}
