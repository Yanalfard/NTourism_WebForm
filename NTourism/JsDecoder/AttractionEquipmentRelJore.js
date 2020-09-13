//---> int id
//---> int AttractionId
//---> int EquipmentId

function AddAttractionEquipmentRel(AttractionEquipmentRel)
{
    return Bjax('/api/AttractionEquipmentRelCore/AddAttractionEquipmentRel', AttractionEquipmentRel, 'LP');
}

function DeleteAttractionEquipmentRel(id)
{
    return Bjax('/api/AttractionEquipmentRelCore/DeleteAttractionEquipmentRel?id=', id, 'SP');
}

function UpdateAttractionEquipmentRel(AttractionEquipmentRel, logId)
{
    var AttractionEquipmentRelLogId = new Array();
    AttractionEquipmentRelLogId.push(AttractionEquipmentRel);
    AttractionEquipmentRelLogId.push(logId);
    return Bjax('/api/AttractionEquipmentRelCore/UpdateAttractionEquipmentRel', AttractionEquipmentRelLogId, 'LP');
}

function SelectAllAttractionEquipmentRels()
{
    return Bjax('/api/AttractionEquipmentRelCore/SelectAllAttractionEquipmentRels', '', 'G');
}

function SelectAttractionEquipmentRelById(id)
{
    return Bjax('/api/AttractionEquipmentRelCore/SelectAttractionEquipmentRelById?id=', id, 'SP');
}

function SelectAttractionEquipmentRelByAttractionId(AttractionId)
{
    return Bjax('/api/AttractionEquipmentRelCore/AttractionId?AttractionId=', AttractionId, 'SP');
}

function SelectAttractionEquipmentRelByEquipmentId(equipmentId)
{
    return Bjax('/api/AttractionEquipmentRelCore/equipmentId?equipmentId=', equipmentId, 'SP');
}

