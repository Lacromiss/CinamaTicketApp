using Application.Abstracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstracts.Common.Interfaces
{
    public interface IUnitOfWork
    {
        ICinemaRepository CinemaRepository { get; }
        IFilmRepository FilmRepository { get; }
        IFilmLanguageRepository FilmLanguageRepository { get; }
        IHallRepository HallRepository { get; }
        ISeatRepository SeatRepository { get; }
        ISessionRepository SessionRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
    
}
