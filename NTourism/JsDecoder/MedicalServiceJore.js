//---> int id
//---> string FirstName
//---> string LastName
//---> string SicknessName
//---> string SicknessDesc
//---> string PassNo
//---> int PassportImageId

{
    return Bjax('/api/MedicalServiceCore/AddMedicalService', medicalService, 'LP');
}

{
    return Bjax('/api/MedicalServiceCore/DeleteMedicalService?id=', id, 'SP');
}

{
    var medicalServiceLogId = new Array();
    medicalServiceLogId.push(medicalService);
    medicalServiceLogId.push(logId);
    return Bjax('/api/MedicalServiceCore/UpdateMedicalService', medicalServiceLogId, 'LP');
}

{
    return Bjax('/api/MedicalServiceCore/SelectAllMedicalServices', '', 'G');
}

{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceById?id=', id, 'SP');
}

{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceByFirstName?firstName=', firstName, 'SP');
}

{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceByLastName?lastName=', lastName, 'SP');
}

{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceBySicknessName?sicknessName=', sicknessName, 'SP');
}

{
    return Bjax('/api/MedicalServiceCore/SelectMedicalServiceByPassportImageId?passportImageId=', passportImageId, 'SP');
}

{
    return Bjax('/api/ImagesCore/SelectImagesByMedicalServiceId?medicalServiceId=', medicalServiceId, 'SP');
}
