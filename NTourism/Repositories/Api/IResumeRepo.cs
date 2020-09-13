using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IResumeRepo
    {
        TblResume AddResume(TblResume resume);
        bool DeleteResume(int id);
        bool UpdateResume(TblResume resume, int logId);
        List<TblResume> SelectAllResumes();
        TblResume SelectResumeById(int id);
        TblResume SelectResumeByName(string name);

    }
}