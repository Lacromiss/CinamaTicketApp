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
    public class FilmLanguageRepository:Repository<FilmLanguage>,IFilmLanguageRepository
    {
        public FilmLanguageRepository(CinemaPlusDbContext context):base(context)
        {
            
        }
    }
}
