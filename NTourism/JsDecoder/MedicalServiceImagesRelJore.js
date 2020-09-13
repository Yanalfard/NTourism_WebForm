//---> int id
//---> int MedicalServiceId
//---> int ImageId
function AddMedicalServiceImagesRel(medicalServiceImagesRel)
{
    return Bjax('/api/MedicalServiceImagesRelCore/AddMedicalServiceImagesRel', medicalServiceImagesRel, 'LP');
}
function DeleteMedicalServiceImagesRel(id)
{
    return Bjax('/api/MedicalServiceImagesRelCore/DeleteMedicalServiceImagesRel?id=', id, 'SP');
}
function UpdateMedicalServiceImagesRel(medicalServiceImagesRel, logId)
{
    var medicalServiceImagesRelLogId = new Array();
    medicalServiceImagesRelLogId.push(medicalServiceImagesRel);
    medicalServiceImagesRelLogId.push(logId);
    return Bjax('/api/MedicalServiceImagesRelCore/UpdateMedicalServiceImagesRel', medicalServiceImagesRelLogId, 'LP');
}
function SelectAllMedicalServiceImagesRels()
{
    return Bjax('/api/MedicalServiceImagesRelCore/SelectAllMedicalServiceImagesRels', '', 'G');
}
function SelectMedicalServiceImagesRelById(id)
{
    return Bjax('/api/MedicalServiceImagesRelCore/SelectMedicalServiceImagesRelById?id=', id, 'SP');
}
function SelectMedicalServiceImagesRelByMedicalServiceId(medicalServiceId)
{
    return Bjax('/api/MedicalServiceImagesRelCore/medicalServiceId?medicalServiceId=', medicalServiceId, 'SP');
}
function SelectMedicalServiceImagesRelByImageId(imageId)
{
    return Bjax('/api/MedicalServiceImagesRelCore/imageId?imageId=', imageId, 'SP');
}
