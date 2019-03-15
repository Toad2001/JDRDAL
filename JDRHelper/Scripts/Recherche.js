$(document).ready(function () {
    $('#btn').click(function () {
        const nom = $('#nom').val();
        $.ajax({
            url: 'http://localhost:3243/api/pj/byname/name=' + nom,
            type: 'Get',
            crossDomain: true,
            dataType: "json",
            success: function (data) {
                affichage(data);
            },
            error: function () {
                alert("Vous n'avez pas mis de nom dans la recherche.");
            }
        })
    });
});

function affichage(data) {
    $('.perso').remove()

    for (var i = 0; i < data.length; i++) {
        const tr = document.createElement('tr')
        const nom = document.createElement('td')
        const sexe = document.createElement('td')
        const race = document.createElement('td')
        const classe = document.createElement('td')
        const signe = document.createElement('td')
        const liens = document.createElement('td')

        $(tr).addClass('perso')
        $(liens).attr('id', 'liens')

        $('<a>', {
            text: 'Edit ',
            title: 'Edit',
            href: '/PJ/Details/'+data[i].Id,
            click: function () { BlahFunc(options.rowId); return false; }
        }).appendTo(liens);

        $('<a>', {
            text: 'Details ',
            title: 'Details',
            href: '/PJ/Details/' + data[i].Id,
            click: function () { BlahFunc(options.rowId); return false; }
        }).appendTo(liens);

        $('<a>', {
            text: 'Delete',
            title: 'Delete',
            href: '/PJ/Details/' + data[i].Id,
            click: function () { BlahFunc(options.rowId); return false; }
        }).appendTo(liens);

        nom.innerText = data[i].Nom
        sexe.innerText = data[i].SexeNom
        race.innerText = data[i].Race.Nom
        classe.innerText = data[i].Classe.Nom
        signe.innerText = data[i].Signe.Nom

        tr.append(nom, sexe, race, classe, signe, liens)


        $('#all').append(tr)
    }
}
