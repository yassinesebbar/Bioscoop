// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    //do work

var url = $('#pdfUrl').text();
var downloadPDF = false;

if(url != ""){
        downloadPDF = true;
}

if(downloadPDF == true){ 
    newWindow = window.open(url, "_blank");
    newWindow.focus();
}



