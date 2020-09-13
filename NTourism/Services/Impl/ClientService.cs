using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class ClientService : IClientService
    {
        public TblClient AddClient(TblClient client)
        {
            return (TblClient)new ClientRepo().AddClient(client);
        }

        public bool DeleteClient(int id)
        {
            return new ClientRepo().DeleteClient(id);
        }

        public bool UpdateClient(TblClient client, int logId)
        {
            return new ClientRepo().UpdateClient(client, logId);
        }

        public List<TblClient> SelectAllClients()
        {
            return new ClientRepo().SelectAllClients();
        }

        public TblClient SelectClientById(int id)
        {
            return new ClientRepo().SelectClientById(id);
        }

        public TblClient SelectClientByFirstName(string firstName)
        {
            return new ClientRepo().SelectClientByFirstName(firstName);
        }

        public List<TblClient> SelectClientByLastName(string lastName)
        {
            return new ClientRepo().SelectClientByLastName(lastName);
        }

        public TblClient SelectClientByEmail(string email)
        {
            return new ClientRepo().SelectClientByEmail(email);
        }

        public TblClient SelectClientByUsername(string username)
        {
            return new ClientRepo().SelectClientByUsername(username);
        }

        public TblClient SelectClientByUsernamePassword(string username, string password)
        {
            return new ClientRepo().SelectClientByUsernamePassword(username, password);
        }

        public List<TblComments> SelectCommentsByClientId(int clientId)
        {
            return new CommentsRepo().SelectCommentsByClientId(clientId);
        }
    }
}