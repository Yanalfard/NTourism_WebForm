//---> int id
//---> string Name

{
    return Bjax('/api/CountryCore/AddCountry', country, 'LP');
}

{
    return Bjax('/api/CountryCore/DeleteCountry?id=', id, 'SP');
}

{
    var countryLogId = new Array();
    countryLogId.push(country);
    countryLogId.push(logId);
    return Bjax('/api/CountryCore/UpdateCountry', countryLogId, 'LP');
}

{
    return Bjax('/api/CountryCore/SelectAllCountries', '', 'G');
}

{
    return Bjax('/api/CountryCore/SelectCountryById?id=', id, 'SP');
}

{
    return Bjax('/api/CountryCore/SelectCountryByName?name=', name, 'SP');
}
