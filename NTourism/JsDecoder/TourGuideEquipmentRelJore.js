//---> int id
//---> int TourGuideId
//---> int EquipmentId

{
    return Bjax('/api/TourGuideEquipmentRelCore/AddTourGuideEquipmentRel', tourGuideEquipmentRel, 'LP');
}

{
    return Bjax('/api/TourGuideEquipmentRelCore/DeleteTourGuideEquipmentRel?id=', id, 'SP');
}

{
    var tourGuideEquipmentRelLogId = new Array();
    tourGuideEquipmentRelLogId.push(tourGuideEquipmentRel);
    tourGuideEquipmentRelLogId.push(logId);
    return Bjax('/api/TourGuideEquipmentRelCore/UpdateTourGuideEquipmentRel', tourGuideEquipmentRelLogId, 'LP');
}

{
    return Bjax('/api/TourGuideEquipmentRelCore/SelectAllTourGuideEquipmentRels', '', 'G');
}

{
    return Bjax('/api/TourGuideEquipmentRelCore/SelectTourGuideEquipmentRelById?id=', id, 'SP');
}

{
    return Bjax('/api/TourGuideEquipmentRelCore/tourGuideId?tourGuideId=', tourGuideId, 'SP');
}

{
    return Bjax('/api/TourGuideEquipmentRelCore/equipmentId?equipmentId=', equipmentId, 'SP');
}
