using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class ResumeRepo: IResumeRepo
    {
        public TblResume AddResume(TblResume resume)
        {
            return (TblResume)new MainProvider().Add(resume);
        }

        public bool DeleteResume(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblResume, id);
        }

        public bool UpdateResume(TblResume resume, int logId)
        {
            return new MainProvider().Update(resume, logId);
        }

        public List<TblResume> SelectAllResumes()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblResume).Cast<TblResume>().ToList();
        }

        public TblResume SelectResumeById(int id)
        {
            return (TblResume) new MainProvider().SelectById(MainProvider.Tables.TblResume, id);
        }

        public TblResume SelectResumeByName(string name)
        {
            return new MainProvider().SelectResumeByName(name);
        }
    }
}