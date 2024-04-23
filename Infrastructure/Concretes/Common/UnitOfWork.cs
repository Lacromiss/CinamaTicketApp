using Application.Abstracts.Common.Interfaces;
using Application.Abstracts.Repositories;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Concretes.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CinemaPlusDbContext _context;

        public UnitOfWork(CinemaPlusDbContext context)
        {
            _context = context;
            
        }
        private ICinemaRepository? _CinemaRepository;
        private IFilmRepository? _FilmRepository;
        private IFilmLanguageRepository? _FilmLanguageRepository;
        private IHallRepository? _IHallRepository;
        private ISeatRepository? _ISeatRepository;
        private ISessionRepository? _ISessionRepository;
        private ILanguageRepository? _ILanguageRepository;

        public ICinemaRepository CinemaRepository => _CinemaRepository ??= new CinemaRepository(_context);

        public IFilmRepository FilmRepository => throw new NotImplementedException();

        public IFilmLanguageRepository FilmLanguageRepository => throw new NotImplementedException();

        public IHallRepository HallRepository => throw new NotImplementedException();

        public ISeatRepository SeatRepository => throw new NotImplementedException();

        public ISessionRepository SessionRepository => throw new NotImplementedException();

        public ILanguageRepository LanguageRepository => throw new NotImplementedException();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
