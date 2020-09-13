//---> int id
//---> int TourGuideId
//---> int ImageId
function AddTourGuideImagesRel(tourGuideImagesRel)
{
    return Bjax('/api/TourGuideImagesRelCore/AddTourGuideImagesRel', tourGuideImagesRel, 'LP');
}
function DeleteTourGuideImagesRel(id)
{
    return Bjax('/api/TourGuideImagesRelCore/DeleteTourGuideImagesRel?id=', id, 'SP');
}
function UpdateTourGuideImagesRel(tourGuideImagesRel, logId)
{
    var tourGuideImagesRelLogId = new Array();
    tourGuideImagesRelLogId.push(tourGuideImagesRel);
    tourGuideImagesRelLogId.push(logId);
    return Bjax('/api/TourGuideImagesRelCore/UpdateTourGuideImagesRel', tourGuideImagesRelLogId, 'LP');
}
function SelectAllTourGuideImagesRels()
{
    return Bjax('/api/TourGuideImagesRelCore/SelectAllTourGuideImagesRels', '', 'G');
}
function SelectTourGuideImagesRelById(id)
{
    return Bjax('/api/TourGuideImagesRelCore/SelectTourGuideImagesRelById?id=', id, 'SP');
}
function SelectTourGuideImagesRelByTourGuideId(tourGuideId)
{
    return Bjax('/api/TourGuideImagesRelCore/tourGuideId?tourGuideId=', tourGuideId, 'SP');
}
function SelectTourGuideImagesRelByImageId(imageId)
{
    return Bjax('/api/TourGuideImagesRelCore/imageId?imageId=', imageId, 'SP');
}
