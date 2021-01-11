// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function randomizarEmail() {
    $.get("/Produtos/RandomizarEmail", function (data) {
        $(".campo-email").html(data);
    });
}

$(document).ready(function () {
    $(".seta-randomiza-email").click(function () {
        randomizarEmail();
    });
});