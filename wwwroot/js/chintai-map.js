let chintaiMap;


function initChintaiMap() {

    // Bangladesh default location

    chintaiMap = L.map('crimeMap')
        .setView(
            [23.8103, 90.4125],
            12
        );



    // OpenStreetMap tiles

    L.tileLayer(
        'https://tile.openstreetmap.org/{z}/{x}/{y}.png',
        {

            maxZoom: 19,

            attribution:
                '&copy; OpenStreetMap contributors'

        }

    ).addTo(chintaiMap);



    // Sample crime hotspot


    addCrimeMarker(
        23.8041,
        90.3687,
        "Mirpur - High Robbery Risk"
    );



    addCrimeMarker(
        23.7500,
        90.3900,
        "Mohammadpur - Theft Risk"
    );



    addCrimeMarker(
        23.8103,
        90.4125,
        "Dhaka Center - Medium Risk"
    );



    getCurrentLocation();


}





function addCrimeMarker(
    latitude,
    longitude,
    message
) {


    let marker = L.marker(
        [
            latitude,
            longitude
        ]

    )
        .addTo(chintaiMap);



    marker.bindPopup(
        `
        <b>🚨 Crime Hotspot</b>
        <br>
        ${message}
        `
    );


}





function getCurrentLocation() {


    if (navigator.geolocation) {


        navigator.geolocation.getCurrentPosition(

            function (position) {


                let latitude =
                    position.coords.latitude;



                let longitude =
                    position.coords.longitude;



                let userMarker =
                    L.marker(
                        [
                            latitude,
                            longitude
                        ]

                    )
                        .addTo(chintaiMap);



                userMarker.bindPopup(
                    "📍 Your Current Location"
                )
                    .openPopup();



                chintaiMap.setView(
                    [
                        latitude,
                        longitude
                    ],
                    14
                );


            }

        );


    }


}
