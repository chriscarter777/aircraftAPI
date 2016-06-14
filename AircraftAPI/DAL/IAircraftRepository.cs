using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AircraftAPI.Models;
using AircraftAPI.DAL;


namespace AircraftAPI.DAL
{
    public interface IAircraftRepository
    {
        int Count();
        IEnumerable<Aircraft> GetAll();
        Aircraft Get(int id);
        void Add(Aircraft ac);
        void Delete(int id);
        void Change(Aircraft ac);
    }
}
