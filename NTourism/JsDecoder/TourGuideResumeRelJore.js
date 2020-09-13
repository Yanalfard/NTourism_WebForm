//---> int id
//---> int TourGuideId
//---> int ResumeId
function AddTourGuideResumeRel(tourGuideResumeRel)
{
    return Bjax('/api/TourGuideResumeRelCore/AddTourGuideResumeRel', tourGuideResumeRel, 'LP');
}
function DeleteTourGuideResumeRel(id)
{
    return Bjax('/api/TourGuideResumeRelCore/DeleteTourGuideResumeRel?id=', id, 'SP');
}
function UpdateTourGuideResumeRel(tourGuideResumeRel, logId)
{
    var tourGuideResumeRelLogId = new Array();
    tourGuideResumeRelLogId.push(tourGuideResumeRel);
    tourGuideResumeRelLogId.push(logId);
    return Bjax('/api/TourGuideResumeRelCore/UpdateTourGuideResumeRel', tourGuideResumeRelLogId, 'LP');
}
function SelectAllTourGuideResumeRels()
{
    return Bjax('/api/TourGuideResumeRelCore/SelectAllTourGuideResumeRels', '', 'G');
}
function SelectTourGuideResumeRelById(id)
{
    return Bjax('/api/TourGuideResumeRelCore/SelectTourGuideResumeRelById?id=', id, 'SP');
}
function SelectTourGuideResumeRelByTourGuideId(tourGuideId)
{
    return Bjax('/api/TourGuideResumeRelCore/tourGuideId?tourGuideId=', tourGuideId, 'SP');
}
function SelectTourGuideResumeRelByResumeId(resumeId)
{
    return Bjax('/api/TourGuideResumeRelCore/resumeId?resumeId=', resumeId, 'SP');
}
