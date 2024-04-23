using Application.Abstracts.Common.Interfaces;
using Application.Abstracts.Repositories;
using Infrastructure.Concretes.Repositoryes;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
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

        public IFilmRepository FilmRepository => _FilmRepository ??= new FilmRepository(_context);

        public IFilmLanguageRepository FilmLanguageRepository => _FilmLanguageRepository ??= new FilmLanguageRepository(_context);

        public IHallRepository HallRepository => _IHallRepository ??= new HallRepository(_context);

        public ISeatRepository SeatRepository => _ISeatRepository ??= new SeatRepository(_context);

        public ISessionRepository SessionRepository => _ISessionRepository ??= new SessionRepository(_context);

        public ILanguageRepository LanguageRepository => _ILanguageRepository ??= new LanguageRepository(_context);

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => await _context.SaveChangesAsync(cancellationToken);


    }
}
