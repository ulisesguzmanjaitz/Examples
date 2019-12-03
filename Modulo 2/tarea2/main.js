function ActualizarTabla() {
    var table = document.getElementById("senate-data");
    table.innerHTML = "";
    CrearTabla(
        CrearLista(
            FiltrarPorMiembros(
                FiltrarEstado(FiltrarEstado),
                FiltrarPartido(FiltrarPartido),
                data.results[0].members
            )
        )
    );
}
function CrearTabla(list) {
    let table = document.getElementById("senate-data");
    table.innerHTML = list;
}

function CrearLista(array) {
    let tablaTotal="";
    tablaTotal += "<tr>";
    // Nombres completos
    tablaTotal += "<th>";
    tablaTotal += "Name";
    tablaTotal += "</th>";
    // Partidos
    tablaTotal += "<th>";
    tablaTotal += "Party";
    tablaTotal += "</th>";
    // Estados
    tablaTotal += "<th>";
    tablaTotal += "State";
    tablaTotal += "</th>";
    // Seniority
    tablaTotal += "<th>";
    tablaTotal += "State";
    tablaTotal += "</th>";
    // Porcentaje de votos por partido
    tablaTotal += "<th>";
    tablaTotal += "% votes w/ party";
    tablaTotal += "</th>";
    tablaTotal += "</tr>";
    for (let i = 0; i < array.length; i++) {
        tablaTotal += "<tr>";
        // Nombre
        tablaTotal += "<td>";
        // If a URL exists
        console.log(array[i].url);
        if (array[i].url != "") {

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
        tablaTotal += "</td>"//Nombre
        // Partido
        tablaTotal += "<td>";
        tablaTotal += array[i].party;
        tablaTotal += "</td>";//Partido
        // Estado
        tablaTotal += "<td>";
        tablaTotal += array[i].state;
        tablaTotal += "</td>";//Estado
        // Seniority
        tablaTotal += "<td>";
        tablaTotal += array[i].seniority;
        tablaTotal += "</td>";//Seniority
        // PERCENTAGE OF VOTES WITH PARTY
        tablaTotal += "<td>";
        tablaTotal += array[i].votes_with_party_pct;
        tablaTotal += " %"
        tablaTotal += "</td>"
        tablaTotal += "</tr>"// PERCENTAGE OF VOTES WITH PARTY
    }
    return tablaTotal;
}

function FiltrarPorMiembros(state,partidos,array) {
    let estadoString;
    let FiltrarMiembros = [];
    let filtrarPorPartido = partidos;

    for (let i = 0; i < array.length; i++) {
        estadoString = ((array[i].state) + ("_state")).toLowerCase();
        if (state == "allStates" || estadoString == state) {
            for (let j = 0; j < filtrarPorPartido.length; j++) {
                if (array[i].party == filtrarPorPartido[j]) {
                    FiltrarMiembros.push(array[i]);
                }
            }
        }
    }
    return FiltrarMiembros;
}

function FiltrarEstado() {
    var state = document.getElementById("fieldSetStates").value;
    return state;
}

function FiltrarPartido() {
    let listaDePartidos = [];
    if (document.getElementById("party_republican").checked == true) {
        listaDePartidos.push("R");
    }
    if (document.getElementById("party_democrat").checked == true) {
        listaDePartidos.push("D");
    }
    if (document.getElementById("party_independent").checked == true) {
        listaDePartidos.push("I");
    }
    return listaDePartidos;
}
ActualizarTabla();
