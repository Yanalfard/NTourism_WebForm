//---> int id
//---> string Name
function AddResume(resume)
{
    return Bjax('/api/ResumeCore/AddResume', resume, 'LP');
}
function DeleteResume(id)
{
    return Bjax('/api/ResumeCore/DeleteResume?id=', id, 'SP');
}
function UpdateResume(resume, logId)
{
    var resumeLogId = new Array();
    resumeLogId.push(resume);
    resumeLogId.push(logId);
    return Bjax('/api/ResumeCore/UpdateResume', resumeLogId, 'LP');
}
function SelectAllResumes()
{
    return Bjax('/api/ResumeCore/SelectAllResumes', '', 'G');
}
function SelectResumeById(id)
{
    return Bjax('/api/ResumeCore/SelectResumeById?id=', id, 'SP');
}
function SelectResumeByName(name)
{
    return Bjax('/api/ResumeCore/SelectResumeByName?name=', name, 'SP');
}
