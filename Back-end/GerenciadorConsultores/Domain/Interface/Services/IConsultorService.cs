using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Services
{
    public interface IConsultorService
    {
        Task<Consultor> getAllConsultores();
        Task<Consultor> getConsultorById(Int32 id);
        Task AddConsultor(Consultor consultor);
        Task UpdateConsultor(Int32 id, Consultor consultor);
        Task DeleteConsultor(Int32 id);
    }
}
