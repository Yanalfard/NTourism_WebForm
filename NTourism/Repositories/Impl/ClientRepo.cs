using System;
using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Services.Impl;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class ClientRepo: IClientRepo
    {
        public TblClient AddClient(TblClient client)
        {
            object obj = new MainProvider().Add(client);
            if(obj.GetType() == typeof(bool))
            {
                return new TblClient(-1);
            }
            else
            {
                return (TblClient)obj;
            }
        }

        public bool DeleteClient(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblClient, id);
        }

        public bool UpdateClient(TblClient client, int logId)
        {
            return new MainProvider().Update(client, logId);
        }

        public List<TblClient> SelectAllClients()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblClient).Cast<TblClient>().ToList();
        }

        public TblClient SelectClientById(int id)
        {
            return (TblClient) new MainProvider().SelectById(MainProvider.Tables.TblClient, id);
        }

        public TblClient SelectClientByFirstName(string firstName)
        {
            return new MainProvider().SelectClientByFirstName(firstName);
        }

        public List<TblClient> SelectClientByLastName(string lastName)
        {
            return new MainProvider().SelectClientByLastName(lastName);
        }

        public TblClient SelectClientByEmail(string email)
        {
            return new MainProvider().SelectClientByEmail(email);
        }

        public TblClient SelectClientByUsername(string username)
        {
            return new MainProvider().SelectClientByUsername(username);
        }

        public TblClient SelectClientByUsernamePassword(string username, string password)
        {
            return new MainProvider().SelectClientByUsernamePassword(username, password);
        }

    }
}