using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class PollService : IPollService
    {
        public TblPoll AddPoll(TblPoll poll)
        {
            return (TblPoll)new PollRepo().AddPoll(poll);
        }
        public bool DeletePoll(int id)
        {
            return new PollRepo().DeletePoll(id);
        }
        public bool UpdatePoll(TblPoll poll, int logId)
        {
            return new PollRepo().UpdatePoll(poll, logId);
        }
        public List<TblPoll> SelectAllPolls()
        {
            return new PollRepo().SelectAllPolls();
        }
        public TblPoll SelectPollById(int id)
        {
            return (TblPoll)new PollRepo().SelectPollById(id);
        }
        public TblPoll SelectPollByName(string name)
        {
            return new PollRepo().SelectPollByName(name);
        }

    }
}