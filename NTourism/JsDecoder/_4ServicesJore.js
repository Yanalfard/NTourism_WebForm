function Update4Services(services, logId) {
    var servicesLogId = new Array();
    servicesLogId.push(services);
    servicesLogId.push(logId);
    return Bjax('/api/Services4/Update4Services', AttractionPollRelLogId, 'LP');
}

function SelectAll4Services() {
    return Bjax('/api/Services4/SelectAll4Services', '', 'G');
}