//---> int id
//---> string Image
//---> string Name
function AddImages(images)
{
    return Bjax('/api/ImagesCore/AddImage', images, 'LP');
}
function DeleteImages(id)
{
    return Bjax('/api/ImagesCore/DeleteImage?id=', id, 'SP');
}
function UpdateImages(images, logId)
{
    var imagesLogId = new Array();
    imagesLogId.push(images);
    imagesLogId.push(logId);
    return Bjax('/api/ImagesCore/UpdateImage', imagesLogId, 'LP');
}
function SelectAllImages()
{
    return Bjax('/api/ImagesCore/SelectAllImages', '', 'G');
}
function SelectImagesById(id)
{
    return Bjax('/api/ImagesCore/SelectImageById?id=', id, 'SP');
}
function SelectImagesByImage(image)
{
    return Bjax('/api/ImagesCore/SelectImagesByImage?image=', image, 'SP');
}
function SelectImagesByName(name)
{
    return Bjax('/api/ImagesCore/SelectImagesByName?name=', name, 'SP');
}
