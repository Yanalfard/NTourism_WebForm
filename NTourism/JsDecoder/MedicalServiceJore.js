//---> int id
//---> string FirstName
//---> string LastName
//---> string SicknessName
//---> string SicknessDesc
//---> string PassNo
//---> int PassportImageId
function AddMedicalService(medicalService)
{
    return Bjax('/api/MedicalServiceCore/AddMedicalService', medicalService, 'LP');
}
function DeleteMedicalService(id)
{
    return Bjax('/api/MedicalServiceCore/DeleteMedicalService?id=', id, 'SP');
}
function UpdateMedicalService(medicalService, logId)
{
    var medicalServiceLogId = new Array();
    medicalServiceLogId.push(medicalService);
    medicalServiceLogId.push(logId);
    return Bjax('/api/MedicalServiceCore/UpdateMedicalService', medicalServiceLogId, 'LP');
}
function SelectAllMedicalServices()
{
    return Bjax('/api/MedicalServiceCore/SelectAllMedicalServices', '', 'G');
}
function SelectMedicalServiceById(id)
{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceById?id=', id, 'SP');
}
function SelectMedicalServiceByFirstName(firstName)
{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceByFirstName?firstName=', firstName, 'SP');
}
function SelectMedicalServiceByLastName(lastName)
{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceByLastName?lastName=', lastName, 'SP');
}
function SelectMedicalServiceBySicknessName(sicknessName)
{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceBySicknessName?sicknessName=', sicknessName, 'SP');
}
function SelectMedicalServiceByPassportImageId(passportImageId)
{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceByPassportImageId?passportImageId=', passportImageId, 'SP');
}
function SelectImagesByMedicalServiceId(medicalServiceId)
{
    return Bjax('/api/ImagesCore/SelectImagesByMedicalServiceId?medicalServiceId=', medicalServiceId, 'SP');
}
