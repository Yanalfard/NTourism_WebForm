using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IPollRepo
    {
        TblPoll AddPoll(TblPoll poll);
        bool DeletePoll(int id);
        bool UpdatePoll(TblPoll poll, int logId);
        List<TblPoll> SelectAllPolls();
        TblPoll SelectPollById(int id);
        TblPoll SelectPollByName(string name);

    }
}