using Youper.API.Shared.Domain.Repositories;
using Youper.API.Shared.Infrastuctures.Persistance.EFC.Configuration;

namespace Youper.API.Shared.Infrastuctures.Persistance.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    /// <inheritdoc />
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}