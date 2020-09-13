//---> int id
//---> string Name
function AddCountry(country)
{
    return Bjax('/api/CountryCore/AddCountry', country, 'LP');
}
function DeleteCountry(id)
{
    return Bjax('/api/CountryCore/DeleteCountry?id=', id, 'SP');
}
function UpdateCountry(country, logId)
{
    var countryLogId = new Array();
    countryLogId.push(country);
    countryLogId.push(logId);
    return Bjax('/api/CountryCore/UpdateCountry', countryLogId, 'LP');
}
function SelectAllCountrys()
{
    return Bjax('/api/CountryCore/SelectAllCountries', '', 'G');
}
function SelectCountryById(id)
{
    return Bjax('/api/CountryCore/SelectCountryById?id=', id, 'SP');
}
function SelectCountryByName(name)
{
    return Bjax('/api/CountryCore/SelectCountryByName?name=', name, 'SP');
}
