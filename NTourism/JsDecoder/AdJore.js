//---> int id
//---> string Image
//---> string Link
function AddAd(ad)
{
    return Bjax('/api/AdCore/AddAd', ad, 'LP');
}
function DeleteAd(id)
{
    return Bjax('/api/AdCore/DeleteAd?id=', id, 'SP');
}
function UpdateAd(ad, logId)
{
    var adLogId = new Array();
    adLogId.push(ad);
    adLogId.push(logId);
    return Bjax('/api/AdCore/UpdateAd', adLogId, 'LP');
}
function SelectAllAds()
{
    return Bjax('/api/AdCore/SelectAllAds', '', 'G');
}
function SelectAdById(id)
{
    return Bjax('/api/AdCore/SelectAdById?id=', id, 'SP');
}
function SelectAdByImage(image)
{
    return Bjax('/api/AdCore/SelectAdByImage?image=', image, 'SP');
}
