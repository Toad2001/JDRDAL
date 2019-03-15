$(document).ready(function () {
    $('#btn1').click(function () {
        alert(getRandomInt(6)+1)
    });

    $('#btn2').click(function () {
        alert(getRandomInt(20)+1)
    });

    $('#btn3').click(function () {
        alert(getRandomInt(100)+1)
    });
});

function getRandomInt(max) {
    return Math.floor(Math.random() * Math.floor(max));
}