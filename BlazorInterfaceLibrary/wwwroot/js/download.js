window.downloadFile = (fileName, mimeType, base64) => {
    const link = document.createElement("a");
    link.href = "data:" + mimeType + ";base64," + base64;
    link.download = fileName;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
