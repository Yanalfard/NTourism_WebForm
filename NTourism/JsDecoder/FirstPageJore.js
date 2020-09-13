//---> int id
//---> string Sign
//---> string Image
//---> string Text
//---> bool IsText

function AddFirstPage(firstPage)
{
    return Bjax('/api/FirstPageCore/AddFirstPage', firstPage, 'LP');
}

function DeleteFirstPage(id)
{
    return Bjax('/api/FirstPageCore/DeleteFirstPage?id=', id, 'SP');
}

function UpdateFirstPage(firstPage, logId)
{
    var firstPageLogId = new Array();
    firstPageLogId.push(firstPage);
    firstPageLogId.push(logId);
    return Bjax('/api/FirstPageCore/UpdateFirstPage', firstPageLogId, 'LP');
}

function SelectAllFirstPages()
{
    return Bjax('/api/FirstPageCore/SelectAllFirstPages', '', 'G');
}

function SelectFirstPageById(id)
{
    return Bjax('/api/FirstPageCore/SelectFirstPageById?id=', id, 'SP');
}

function SelectFirstPageByImage(image)
{
    return Bjax('/api/FirstPageCore/SelectFirstPageByImage?image=', image, 'SP');
}

function SelectFirstPageByIsText(isText)
{
    return Bjax('/api/FirstPageCore/SelectFirstPageByIsText?isText=', isText, 'SP');
}

