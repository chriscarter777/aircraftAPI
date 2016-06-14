using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AircraftAPI.Models;
using AircraftAPI.DAL;


namespace AircraftAPI.DAL
{
    public class AircraftRepository : IAircraftRepository
    {
        private AircraftDbContext context = new AircraftDbContext();

        public int Count()
        {
            return context.Aircraft.Count();
        }

        public IEnumerable<Aircraft> GetAll()
        {
            return context.Aircraft;
        }
        public Aircraft Get(int id)
        {
            return context.Aircraft.Find(id);
        }
        public void Add(Aircraft ac)
        {
            context.Aircraft.Add(ac);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Aircraft ac = context.Aircraft.Find(id);
            context.Aircraft.Remove(ac);
            context.SaveChanges();
        }
        public void Change(Aircraft acNew)
        {
            Aircraft acOld = context.Aircraft.Find(acNew.Id);
            acOld.Name = acNew.Name;
            acOld.Seats = acNew.Seats;
            acOld.Hp = acNew.Hp;
            acOld.Cruise = acNew.Cruise;
            acOld.Climb = acNew.Climb;
            acOld.Price = acNew.Price;
            context.SaveChanges();
        }
    }
}