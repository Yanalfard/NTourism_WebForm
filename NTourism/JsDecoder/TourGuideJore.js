//---> int id
//---> string FirstName
//---> string LastName
//---> string TellNo
//---> string Email
//---> string MainImage
//---> string Description
//---> string Username
//---> string Password
//---> int CityId

function AddTourGuide(tourGuide)
{
    return Bjax('/api/TourGuideCore/AddTourGuide', tourGuide, 'LP');
}

function DeleteTourGuide(id)
{
    return Bjax('/api/TourGuideCore/DeleteTourGuide?id=', id, 'SP');
}

function UpdateTourGuide(tourGuide, logId)
{
    var tourGuideLogId = new Array();
    tourGuideLogId.push(tourGuide);
    tourGuideLogId.push(logId);
    return Bjax('/api/TourGuideCore/UpdateTourGuide', tourGuideLogId, 'LP');
}

function SelectAllTourGuides()
{
    return Bjax('/api/TourGuideCore/SelectAllTourGuides', '', 'G');
}

function SelectTourGuideById(id)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideById?id=', id, 'SP');
}

function SelectTourGuideByFirstName(firstName)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByFirstName?firstName=', firstName, 'SP');
}

function SelectTourGuideByFirstNameAndLastName(firstName, lastName)
{
    var args = new Array();
    args.push(firstName);
    args.push(lastName);
    return Bjax('/api/TourGuideCore/SelectTourGuideByFirstNameAndLastName', args, 'LP');
}

function SelectTourGuideByLastName(lastName)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByLastName?lastName=', lastName, 'SP');
}

function SelectTourGuideByTellNo(tellNo)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByTellNo?tellNo=', tellNo, 'SP');
}

function SelectTourGuideByEmail(email)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByEmail?email=', email, 'SP');
}

function SelectTourGuideByUsernameAndPassword(username, password)
{
    var args = new Array();
    args.push(username);
    args.push(password);
    return Bjax('/api/TourGuideCore/SelectTourGuideByUsernameAndPassword', args, 'LP');
}

function SelectTourGuideByUsername(username)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByUsername?username=', username, 'SP');
}

function SelectTourGuideByPassword(password)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByPassword?password=', password, 'SP');
}

function SelectTourGuideByCityId(cityId)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByCityId?cityId=', cityId, 'SP');
}

function SelectEquipmentsByTourGuide(tourGuideId)
{
    return Bjax('/api/TourGuideCore/SelectEquipmentsByTourGuide?tourGuideId=', tourGuideId, 'SP');
}


function SelectTourGuideByDiscount(cityId)
{
    return Bjax('/api/TourGuideCore/SelectTourGuideByDiscount?cityId=', cityId, 'SP');
}
function SelectImagesByTourGuide(tourGuideId) {
    return Bjax('/api/TourGuideCore/SelectImagesByTourGuide?tourGuideId=', tourGuideId, 'SP');
}

