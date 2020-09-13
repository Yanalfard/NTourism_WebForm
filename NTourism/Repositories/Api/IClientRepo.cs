using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IClientRepo
    {
        TblClient AddClient(TblClient client);
        bool DeleteClient(int id);
        bool UpdateClient(TblClient client, int logId);
        List<TblClient> SelectAllClients();
        TblClient SelectClientById(int id);
        TblClient SelectClientByFirstName(string firstName);
        List<TblClient> SelectClientByLastName(string lastName);
        TblClient SelectClientByEmail(string email);
        TblClient SelectClientByUsername(string username);
        TblClient SelectClientByUsernamePassword(string username, string password);
    }
}