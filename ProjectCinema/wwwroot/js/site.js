// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function createAndShowModal(url, holderId, modalId) {    
    $.ajax({
        url: url,
        success: function (result) {
            $("#" + holderId).html(result);
            $("#" + modalId).modal();            
        }
    });
}

$(document).ready(function () {
    $('.update-movie').click(function () {        
        $('#update-movie-modal').modal();
    });
    $('#create-movie').click(function () {
        $('#create-movie-modal').modal();
    });
    $('#search-movie').click(function () {
        $('#form').css({ 'display': 'block' })
        $('#search-movie').css({'display': 'none'})
    });
   
    $('#img').attr('placeholder', 'Upload image');
    /*$('#movieTable').DataTable({ 'ordering': true });*/
});