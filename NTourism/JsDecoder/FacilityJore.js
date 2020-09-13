//---> int id
//---> string Name
function AddFacility(facility)
{
    return Bjax('/api/FacilityCore/AddFacility', facility, 'LP');
}
function DeleteFacility(id)
{
    return Bjax('/api/FacilityCore/DeleteFacility?id=', id, 'SP');
}
function UpdateFacility(facility, logId)
{
    var facilityLogId = new Array();
    facilityLogId.push(facility);
    facilityLogId.push(logId);
    return Bjax('/api/FacilityCore/UpdateFacility', facilityLogId, 'LP');
}
function SelectAllFacilities()
{
    return Bjax('/api/FacilityCore/SelectAllFacilities', '', 'G');
}
function SelectFacilityById(id)
{
    return Bjax('/api/FacilityCore/SelectFacilityById?id=', id, 'SP');
}
function SelectFacilityByName(name)
{
    return Bjax('/api/FacilityCore/SelectFacilityByName?name=', name, 'SP');
}
