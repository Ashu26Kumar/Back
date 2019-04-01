using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Backend.Models.manager
{
    public class BrokerManager : IRepository<Broker>
    {
        private readonly dbContext _dbContext;
        public BrokerManager(dbContext context) { _dbContext = context; }

        public IEnumerable<Broker> getAll()
        {
                var  brokers = _dbContext.Brokers.ToList();
                return brokers;
        }

        
        public async Task add(Broker value)
        {
            
            _dbContext.Add(value);
            await _dbContext.SaveChangesAsync();
            
        }

        public async Task update(int id,Broker T)
        {
            var broker = _dbContext.Brokers.SingleOrDefault(m =>m.id==id);
            broker.name = T.name;
            broker.email = T.email;
            broker.state = T.state;
            broker.city = T.city;
            broker.address1 = T.address1;
            broker.address2 = T.address2;
            broker.commission = T.commission;
            await _dbContext.SaveChangesAsync();

        }

        public async Task delete(int id)
        {
            try {
                var broker = _dbContext.Brokers.First(m => m.id == id);
                _dbContext.Brokers.Remove(broker);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
           

        }

        public dynamic get(int id)
        {
            try
            {
                var broker = _dbContext.Brokers.First(m => m.id == id);
                return broker;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Enumerable.Empty<Broker>();
            }
        }
    }
}