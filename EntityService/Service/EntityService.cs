using EntityWeb.DatabaseContext;
using EntityWeb.Interface;
using EntityWeb.Model;

namespace EntityWeb.Service
{
    public class EntityService : IService<Entity>
    {
        private readonly EntityDbContext _context;

        public EntityService(EntityDbContext context)
        {
            _context = context;
        }

        public async Task Add(Entity entry)
        {
            _context.Entities.Add(entry);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<Entity?> Get(Guid id)
        {
            return await _context.Entities.FindAsync(id);
        }
    }
}
