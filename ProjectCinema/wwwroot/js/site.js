// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#update-movie').click(function () {        
        $('#update-movie-modal').modal();
    });
    $('#create-movie').click(function () {
        $('#create-movie-modal').modal();
    });
});