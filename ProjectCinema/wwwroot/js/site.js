// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#search-movie').click(function () {
        $('#form').css({ 'display': 'block' });
        $('#search-movie').css({ 'display': 'none' });
    });
    $('#ticket-modal').click(function () {
        $('#update-ticket-modal').modal();
    });
    $('#movie').click(function () {
        $('#update-movie-modal').modal();
    });   
    $('#img').attr('placeholder', 'Upload image');
    /*$('#movieTable').DataTable({ 'ordering': true });*/
});