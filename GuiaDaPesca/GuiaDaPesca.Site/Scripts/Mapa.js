google.maps.event.addDomListener(window, 'load', initialize);

function initialize() {

    console.log('a');

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

    var map = new google.maps.Map(document.getElementById('mapa'), mapOptions);
}