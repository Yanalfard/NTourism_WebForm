//---> int id
//---> int TourGuideId
//---> int EquipmentId
function AddTourGuideEquipmentRel(tourGuideEquipmentRel)
{
    return Bjax('/api/TourGuideEquipmentRelCore/AddTourGuideEquipmentRel', tourGuideEquipmentRel, 'LP');
}
function DeleteTourGuideEquipmentRel(id)
{
    return Bjax('/api/TourGuideEquipmentRelCore/DeleteTourGuideEquipmentRel?id=', id, 'SP');
}
function UpdateTourGuideEquipmentRel(tourGuideEquipmentRel, logId)
{
    var tourGuideEquipmentRelLogId = new Array();
    tourGuideEquipmentRelLogId.push(tourGuideEquipmentRel);
    tourGuideEquipmentRelLogId.push(logId);
    return Bjax('/api/TourGuideEquipmentRelCore/UpdateTourGuideEquipmentRel', tourGuideEquipmentRelLogId, 'LP');
}
function SelectAllTourGuideEquipmentRels()
{
    return Bjax('/api/TourGuideEquipmentRelCore/SelectAllTourGuideEquipmentRels', '', 'G');
}
function SelectTourGuideEquipmentRelById(id)
{
    return Bjax('/api/TourGuideEquipmentRelCore/SelectTourGuideEquipmentRelById?id=', id, 'SP');
}
function SelectTourGuideEquipmentRelByTourGuideId(tourGuideId)
{
    return Bjax('/api/TourGuideEquipmentRelCore/tourGuideId?tourGuideId=', tourGuideId, 'SP');
}
function SelectTourGuideEquipmentRelByEquipmentId(equipmentId)
{
    return Bjax('/api/TourGuideEquipmentRelCore/equipmentId?equipmentId=', equipmentId, 'SP');
}
