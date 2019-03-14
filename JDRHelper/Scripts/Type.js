$(document).ready(function () {
    $('#carac > p').slice(-6).addClass('mage')
    $('#carac > p').slice(-12,-6).addClass('voleur')
    $('#carac > p').slice(-18, -12).addClass('guerrier')

    $('#lvl > p').slice(1, 2).addClass('guerrier')
    $('#lvl > p').slice(4, 5).addClass('guerrier')

    $('#lvl > p').slice(2, 3).addClass('voleur')
    $('#lvl > p').slice(5, 6).addClass('voleur')

    $('#lvl > p').slice(3, 4).addClass('mage')
    $('#lvl > p').slice(6, 7).addClass('mage')
});