﻿using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Repositories
{
    internal class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopRepository(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
        {

            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Domain.Entities.CarWorkshop?> GetByName(string name)
        {
            return await _dbContext.CarWorkshops.FirstOrDefaultAsync(cw => cw.Name.ToLower() == name.ToLower());
        }

        public async Task<IEnumerable<Domain.Entities.CarWorkshop>> GetAll()
        {
            return await _dbContext.CarWorkshops.ToListAsync();
        }

        public async Task<Domain.Entities.CarWorkshop?> GetByEncodedName(string encodedName)
        {
            return await _dbContext.CarWorkshops.FirstAsync(cw => cw.EncodedName.ToLower() == encodedName.ToLower());
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
