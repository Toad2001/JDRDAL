$(document).ready(function () {
    $('#btn').click(function () {
        $('.details').remove()
        const nom = $('#nom').val();



        $.ajax({
            url: 'http://localhost:3243/api/pj',
            type: 'Get',
            //type: 'Post',

            crossDomain: true,            
            dataType: "json",

            success: function (data) {
                console.log(data);
            },
                error: function() {
                    alert("nope");
                }
        })        
    });
});
