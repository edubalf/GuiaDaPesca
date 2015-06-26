google.maps.event.addDomListener(window, 'load', initialize);

var map;
var locaisDePesca;

function initialize() {

    if (document.getElementById('mapa') != null) {

        var mapOptions = {
            center: { lat: -23.488232, lng: -46.607332 },
            disableDefaultUI: true,
            mapTypeControl: true,
            streetViewControl: true,
            zoomControl: true,
            zoomControlOptions: {
                style: google.maps.ZoomControlStyle.SMALL,
                position: google.maps.ControlPosition.RIGHT_BOTTOM
            },
            zoom: 8
        };

        map = new google.maps.Map(document.getElementById('mapa'), mapOptions);

        PopularMapa();
    }
}

function PopularMapa()
{
    $.ajax(
        {
            type: 'GET',
            url: '/GuiaDaPesca/BuscarLocaisDePesca',
            dataType: 'html',
            success: function (data)
            {
                locaisDePesca = JSON.parse(data);

                console.log(locaisDePesca);

                var markers = [];

                for (var count = 0; count < locaisDePesca.length; count++) {

                    IncluirMarker(locaisDePesca[count]);
                }
            }
        });
}

function IncluirMarker(localDePesca)
{
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(localDePesca.Localizacao.Latitude, localDePesca.Localizacao.Longitude),
        map: map
    });

    var texto = '<strong>Nome:</strong> ' + localDePesca.Nome + '<br>' +
                '<strong>Tipo:</strong> ' + localDePesca.TipoLocalDePesca.Comentario.Descricao + '<br>' +
                '<a href="#" onclick="AbrirPopup(\'' + localDePesca.Id + '\', \'liComentario\');">' + localDePesca.Comentarios.length + ' Comentarios</a>';

    var infowindow = new google.maps.InfoWindow({
        content: texto
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.open(map, marker);
    });
}

function AbrirPopup(localDePescaId, tab)
{
    console.log(localDePescaId);
    var local = null;

    for (var count = 0; count < locaisDePesca.length; count++) {

        if (locaisDePesca[count].Id == localDePescaId) {
            local = locaisDePesca[count];
        }
    }

    if (local != null)
    {
        document.getElementById('localDePescaSelecionado').value = localDePescaId;

        $('#popup').modal();

        document.getElementById(tab).click();
        CarregarComentarios(local.Comentarios);
    }
}

function CarregarComentarios(Comentarios)
{
    var textoComentario = '';

    console.log(Comentarios)

    for (var count = 0; count < Comentarios.length; count++) {

        console.log(Comentarios[count].Usuario);
        var data = new Date(Comentarios[count].DataCriacao);

        textoComentario += '<div class="panel panel-default">' +
                             '<div class="panel-heading">' + Comentarios[count].Usuario.Email + ' - ' + data.getDate() + '/' + data.getMonth() + '/' + data.getFullYear() + '</div>' +
                             '<div class="panel-body">' + Comentarios[count].Descricao + '</div>' +
                           '</div>'
    }

    document.getElementById('divConteudoComentarios').innerHTML = textoComentario;
}