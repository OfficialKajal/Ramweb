﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#theme').on("Chnage", function () {
    var item = $("#theme option:selected").text();

    $.post("Home/ColorTheme",
        {
            data: item
        });


});

