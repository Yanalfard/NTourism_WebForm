//---> int id
//---> int TourGuideId
//---> int ResumeId

{
    return Bjax('/api/TourGuideResumeRelCore/AddTourGuideResumeRel', tourGuideResumeRel, 'LP');
}

{
    return Bjax('/api/TourGuideResumeRelCore/DeleteTourGuideResumeRel?id=', id, 'SP');
}

{
    var tourGuideResumeRelLogId = new Array();
    tourGuideResumeRelLogId.push(tourGuideResumeRel);
    tourGuideResumeRelLogId.push(logId);
    return Bjax('/api/TourGuideResumeRelCore/UpdateTourGuideResumeRel', tourGuideResumeRelLogId, 'LP');
}

{
    return Bjax('/api/TourGuideResumeRelCore/SelectAllTourGuideResumeRels', '', 'G');
}

{
    return Bjax('/api/TourGuideResumeRelCore/SelectTourGuideResumeRelById?id=', id, 'SP');
}

{
    return Bjax('/api/TourGuideResumeRelCore/tourGuideId?tourGuideId=', tourGuideId, 'SP');
}

{
    return Bjax('/api/TourGuideResumeRelCore/resumeId?resumeId=', resumeId, 'SP');
}
