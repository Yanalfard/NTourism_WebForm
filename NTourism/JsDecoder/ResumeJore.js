//---> int id
//---> string Name

{
    return Bjax('/api/ResumeCore/AddResume', resume, 'LP');
}

{
    return Bjax('/api/ResumeCore/DeleteResume?id=', id, 'SP');
}

{
    var resumeLogId = new Array();
    resumeLogId.push(resume);
    resumeLogId.push(logId);
    return Bjax('/api/ResumeCore/UpdateResume', resumeLogId, 'LP');
}

{
    return Bjax('/api/ResumeCore/SelectAllResumes', '', 'G');
}

{
    return Bjax('/api/ResumeCore/SelectResumeById?id=', id, 'SP');
}

{
    return Bjax('/api/ResumeCore/SelectResumeByName?name=', name, 'SP');
}
