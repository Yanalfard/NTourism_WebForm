//---> int id
//---> string Name
//---> string Logo
function AddEquipment(equipment)
{
    return Bjax('/api/EquipmentCore/AddEquipment', equipment, 'LP');
}
function DeleteEquipment(id)
{
    return Bjax('/api/EquipmentCore/DeleteEquipment?id=', id, 'SP');
}
function UpdateEquipment(equipment, logId)
{
    var equipmentLogId = new Array();
    equipmentLogId.push(equipment);
    equipmentLogId.push(logId);
    return Bjax('/api/EquipmentCore/UpdateEquipment', equipmentLogId, 'LP');
}
function SelectAllEquipments()
{
    return Bjax('/api/EquipmentCore/SelectAllEquipments', '', 'G');
}
function SelectEquipmentById(id)
{
    return Bjax('/api/EquipmentCore/SelectEquipmentById?id=', id, 'SP');
}
function SelectEquipmentByName(name)
{
    return Bjax('/api/EquipmentCore/SelectEquipmentByName?name=', name, 'SP');
}
