"use stricts";
var contadorPartidos = [0, 0, 0]; //Republicano,Democrata e Independiente 
var porcentajeVotosPorPartido = [0, 0, 0]; //Republicano,Democrata e Independiente 
var table;
var contadorRepresentantes = 0;
var diezPorciento = 0;
var votosPerdidos = -1;
cargarTablaGalance();
cargarTablaLeast();
cargarTablaMost();

function ordenarArray(array, table) {
    if (table.getAttribute("id") == "least-engaged") {
        array.sort(
            function (a, b) {
                if (a.missed_votes_pct === b.missed_votes_pct) {
                    return a.missed_votes_pct - b.missed_votes_pct;
                }
                return a.missed_votes_pct > b.missed_votes_pct ? 1 : -1;
            });
        console.log(array, "least"); //ordenar por votos perdidos
    } else {
        array.sort(
            function (a, b) {
                if (a.missed_votes_pct === b.missed_votes_pct) {

                    return b.missed_votes_pct - a.missed_votes_pct;
                }
                return a.missed_votes_pct < b.missed_votes_pct ? 1 : -1;
            });
        console.log(array, "most"); //ordenar por votos perdidos
    }
}
//tabla2
function CrearTablaLeastEngaged(list) {
    table = document.getElementById("least-engaged");
    table.innerHTML = list;
}

function cargarTablaLeast() {
    table = document.getElementById("least-engaged");
    table.innerHTML = "";
    CrearTablaLeastEngaged(
        crearLista(
            data.results[0].members,
            table
        )
    );
}

function crearLista(array, table) {
    let tablaTotal = "";
    tablaTotal += "<thead><tr><th>"; //cabecera  tabla
    tablaTotal += "Name";
    tablaTotal += "</th><th>";
    if (document.getElementById("engaged") !== null) {
        tablaTotal += "No Missed Votes";
        tablaTotal += "</th><th>";
        tablaTotal += "% Missed";
    } else if (document.getElementById("loyal") !== null) {
        tablaTotal += "No. Party Votes";
        tablaTotal += "</th><th>";
        tablaTotal += "% Party Votes";
    }
    tablaTotal += "</th><th>";
    tablaTotal += "Party";
    tablaTotal += "</th></thead></tr>";
    //
    ordenarArray(array, table); //ordenar 
    contadorRepresentantes = 0;
    diezPorciento = ((array.length / 100) * 10).toFixed(0);
    votosPerdidos = -1;
    //cambia el valor de i de el orden
    for (let i = 0; i < array.length; i++) {
        contadorRepresentantes++;
        if (contadorRepresentantes == diezPorciento) {
            votosPerdidos = array[i].missed_votes;
        }
        if (((table.getAttribute("id") == "least-engaged") && ((votosPerdidos != -1) && (array[i].missed_votes > votosPerdidos))) || ((table.getAttribute("id") == "most-engaged") && ((votosPerdidos != -1) && (array[i].missed_votes < votosPerdidos)))) {
            break;
        }
        tablaTotal += "<tr>";
        tablaTotal += "<td>"; // Nombre
        if (array[i].url === null) { // If a URL exists
            tablaTotal += "<a href=\"";
            tablaTotal += array[i].url;
            tablaTotal += "\">";
        }
        tablaTotal += array[i].last_name;
        tablaTotal += ", ";
        tablaTotal += array[i].first_name;
        tablaTotal += " ";
        tablaTotal += (array[i].middle_name || "");
        if (array[i].url != "") {
            tablaTotal += "</a>";
        }
        if (document.getElementById("loyal")) {
            // NO. PARTY VOTES
            tablaTotal += "<td>";
            tablaTotal += Math.round(array[i].total_votes * array[i].votes_with_party_pct / 100);
            tablaTotal += "</td>";
            // % PARTY VOTES
            tablaTotal += "<td>";
            tablaTotal += array[i].votes_with_party_pct;
        } else if (document.getElementById("engaged")) {
            // NO. MISSED VOTES
            tablaTotal += "<td>";
            tablaTotal += array[i].missed_votes;
            tablaTotal += "</td>";
            // % MISSED VOTES
            tablaTotal += "<td>";
            tablaTotal += array[i].missed_votes_pct;
        }
        tablaTotal += " %";
        tablaTotal += "</td>";
        tablaTotal += "</td><td>";
        tablaTotal += array[i].party;
        tablaTotal += "</td></tr>";
    }
    contadorRepresentantes = 0;
    diezPorciento = 0;
    votosPerdidos = -1;
    return tablaTotal;
}
//tabla2
function cargarTablaMost() {
    table = document.getElementById("most-engaged");
    table.innerHTML = "";
    CrearTablaMostEngaged(
        crearLista(data.results[0].members, table)
    );
}

function CrearTablaMostEngaged(list) {
    table = document.getElementById("most-engaged");
    table.innerHTML = list;
}

//tabla1
function CrearTablaGalance(list) {
    let table = document.getElementById("senate-at-glance");
    table.innerHTML = list;
}

function cargarTablaGalance() {
    var table = document.getElementById("senate-at-glance");
    table.innerHTML = "";
    CrearTablaGalance(
        CrearListaGalance(
            data.results[0].members
        )
    );
}

function CrearListaGalance(array) {
    let tablaTotal = "";
    //cabecera  tabla
    tablaTotal += "<thead><tr><th>";
    tablaTotal += "Party";
    tablaTotal += "</th><th>";
    tablaTotal += "Number of Reps";
    tablaTotal += "</th><th>";
    tablaTotal += "% Voted with Party";
    tablaTotal += "</th></thead></tr>";
    //
    for (let i = 0; i < array.length; i++) {
        switch (array[i].party) {
            case 'R':
                contadorPartidos[0]++;
                porcentajeVotosPorPartido[0] += array[i].votes_with_party_pct;
                break;
            case 'D':
                contadorPartidos[1]++;
                porcentajeVotosPorPartido[1] += array[i].votes_with_party_pct;
                break;
            case 'I':
                contadorPartidos[2]++;
                porcentajeVotosPorPartido[2] += array[i].votes_with_party_pct;
                break;
        }
    }
    tablaTotal += "<tbody><tr><td>";
    tablaTotal += "Republican";
    tablaTotal += "</td><td>";
    tablaTotal += contadorPartidos[0];
    tablaTotal += "</td><td>";
    tablaTotal += (porcentajeVotosPorPartido[0] / contadorPartidos[0]).toFixed(2);
    tablaTotal += "%";
    tablaTotal += "</td></tr><tr><td>";
    tablaTotal += "Democrat";
    tablaTotal += "</td><td>";
    tablaTotal += contadorPartidos[1];
    tablaTotal += "</td><td>";
    tablaTotal += (porcentajeVotosPorPartido[1] / contadorPartidos[1]).toFixed(2);
    tablaTotal += "%";
    tablaTotal += "</td></tr>";
    tablaTotal += "<tr><td>";
    tablaTotal += "Independient";
    tablaTotal += "</td><td>";
    tablaTotal += contadorPartidos[2];
    tablaTotal += "</td><td>";
    if (contadorPartidos[2] === 0) {
        tablaTotal += 0;
        statics.I[1] = 0;
    } else {
        tablaTotal += (porcentajeVotosPorPartido[2] / contadorPartidos[2]).toFixed(2);
        statics.I[1] = (porcentajeVotosPorPartido[2] / contadorPartidos[2]).toFixed(2);
    }
    console.log(statics);
    tablaTotal += "%";
    tablaTotal += "</td></tr>";
    tablaTotal += "<tr><td>";
    tablaTotal += "Total";
    tablaTotal += "</td><td>";
    tablaTotal += contadorPartidos[0] + contadorPartidos[1] + contadorPartidos[2];
    tablaTotal += "</td><td>";
    tablaTotal += ((porcentajeVotosPorPartido[0] + porcentajeVotosPorPartido[1] + porcentajeVotosPorPartido[2]) / (contadorPartidos[0] + contadorPartidos[1] + contadorPartidos[2])).toFixed(2); //calculo para sacar el promedio total de "% Voted with Party"
    tablaTotal += "</td></tr></tbody>";
    /*statics.D = contadorPartidos[0];
    statics.R = contadorPartidos[1];
    statics.I = contadorPartidos[2];*/
    statics.D[0] = contadorPartidos[0];
    statics.D[1] = (porcentajeVotosPorPartido[0] / contadorPartidos[0]).toFixed(2);
    statics.R[0] = contadorPartidos[1];
    statics.R[1] = (porcentajeVotosPorPartido[1] / contadorPartidos[1]).toFixed(2);
    statics.I[0] = contadorPartidos[2];

    statics.Total[0] = contadorPartidos[0] + contadorPartidos[1] + contadorPartidos[2];
    statics.Total[1] = ((porcentajeVotosPorPartido[0] + porcentajeVotosPorPartido[1] + porcentajeVotosPorPartido[2]) / (contadorPartidos[0] + contadorPartidos[1] + contadorPartidos[2])).toFixed(2);

    // statics.all = contadorPartidos[0] + contadorPartidos[1] + contadorPartidos[2];
    console.log(statics);
    return tablaTotal;
}
//tabla1

/*


var datos;const url = "https://api.propublica.org/congress/v1/113/senate/members.json";const init={

     method: 'GET',

     mode: 'cors',

     headers: {'X-API-Key': 'g74T0tnebPjfTrjrJgBXKsxsRgS4tueQeYHijCMN'}

};function traerJson(){

 fetch(url,init)

   .then(respuesta =>

     respuesta.ok ?

     respuesta.json().then(datos => {app.miembros = datos.results[0].members})

     : console.log("Error"));

}traerJson();var app= new Vue({

el: '#senate-data',

data:{

   miembros: {}

}})

Ese de arriba es el codigo js.

Este es el html:

<div id="app">

 <div class="container">

         <div class="table-responsive">

             <table class="table" id="senate-data">

                 <thead class="thead-dark">

                     <tr>

                         <th>Full Name</th>

                         <th>Party</th>

                         <th>State </th>

                         <th>Seniority</th>

                         <th>Percentage of votes with party</th>

                     </tr>

                 </thead>

                 <tbody>

               <tr v-for="(value, key) in miembros">

               <td> {{value.first_name}} {{value.middle_name}} {{value.last_name}}</td>

               <td>{{value.party}}</td>

               <td>{{value.state}}</td>

               <td>{{value.seniority}}</td>

               <td>{{value.votes_with_party_pct}}</td>

             </tr>

           </tbody>

             </table>

         </div>

     </div>

</div>



*/




//PARA VUEJS

var datos;

const url = "https://api.propublica.org/congress/v1/113/senate/members.json";
const init = {
    method: 'GET',
    mode: 'cors',
    headers: {
        'X-API-Key': 'Y6ZlNtET0Ou6o5szhV9gNlx75BNYP6zRuS3TNzsP'
    }
};







catch (function (error) {
        console.log("Request failed: " + error.message);


        function traerJson() {
            fetch(url, init)
                .then(respuesta =>
                    respuesta.ok ?
                    respuesta.json().then(data => {
                        app.members = data.results[0].members;
                        app.first_name = cargarFirstname(app.first_name);
                        app.middle_name = cargarMiddleName(app.middle_name);
                        app.last_name = cargarLastname(app.last_name);
                        app.noMissedVotes = cargarNoMissedVotes(app.noMissedVotes);
                        app.missed = cargarMissed(app.missed);
                        app.party = cargarParty(app.party);
/*                        cargarTablaLeast(app.members);*/
                    }) /*vm.miembros=datos.results[0].members;*/ :
                    console.log("Error"));
        }
        traerJson();

        var app = new Vue({
            el: '#app',
            data: {
                first_name: {},
                middle_name: {},
                last_name: {},
                noMissedVotes: {},
                missed: {},
                party: {}
            },

        });

        //PARA VUEJS
