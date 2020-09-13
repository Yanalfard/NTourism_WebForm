using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class ResumeService : IResumeService
    {
        public TblResume AddResume(TblResume resume)
        {
            return (TblResume)new ResumeRepo().AddResume(resume);
        }

        public bool DeleteResume(int id)
        {
            return new ResumeRepo().DeleteResume(id);
        }

        public bool UpdateResume(TblResume resume, int logId)
        {
            return new ResumeRepo().UpdateResume(resume, logId);
        }

        public List<TblResume> SelectAllResumes()
        {
            return new ResumeRepo().SelectAllResumes();
        }

        public TblResume SelectResumeById(int id)
        {
            return new ResumeRepo().SelectResumeById(id);
        }

        public TblResume SelectResumeByName(string name)
        {
            return new ResumeRepo().SelectResumeByName(name);
        }
    }
}