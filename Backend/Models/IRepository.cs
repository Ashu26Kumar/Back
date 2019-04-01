using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public interface IRepository<Entity>
    {
         IEnumerable<Entity> getAll();
         dynamic get(int id);
         Task add(Entity T);
         Task update(int id ,Entity T);
         Task delete(int id);
    } 
}
