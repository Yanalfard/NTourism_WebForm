using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class PollRepo : IPollRepo
    {
        public TblPoll AddPoll(TblPoll poll)
        {
            return (TblPoll)new MainProvider().Add(poll);
        }
        public bool DeletePoll(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblPoll, id);
        }
        public bool UpdatePoll(TblPoll poll, int logId)
        {
            return new MainProvider().Update(poll, logId);
        }
        public List<TblPoll> SelectAllPolls()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblPoll).Cast<TblPoll>().ToList();
        }
        public TblPoll SelectPollById(int id)
        {
            return (TblPoll)new MainProvider().SelectById(MainProvider.Tables.TblPoll, id);
        }
        public TblPoll SelectPollByName(string name)
        {
            return new MainProvider().SelectPollByName(name);
        }

    }
}