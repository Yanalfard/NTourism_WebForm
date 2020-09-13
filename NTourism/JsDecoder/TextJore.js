//---> int id
//---> string Text
//---> string Rtf
function AddText(text)
{
    return Bjax('/api/TextCore/AddText', text, 'LP');
}
function DeleteText(id)
{
    return Bjax('/api/TextCore/DeleteText?id=', id, 'SP');
}
function UpdateText(text, logId)
{
    var textLogId = new Array();
    textLogId.push(text);
    textLogId.push(logId);
    return Bjax('/api/TextCore/UpdateText', textLogId, 'LP');
}
function SelectAllTexts()
{
    return Bjax('/api/TextCore/SelectAllTexts', '', 'G');
}
function SelectTextById(id)
{
    return Bjax('/api/TextCore/SelectTextById?id=', id, 'SP');
}
