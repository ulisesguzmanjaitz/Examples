/*DOS*/
var myname = "mi nombre";
var age = 25;
var ignasiAge = 32;
var ageDiff = 25 - ignasiAge;

function soyMayorDe(age) {
    if (age > 21) {
        return 'Soy mayor de 21';
    } else if (age < 21) {
        return 'Soy menor de 21';
    }
}

function compareAge(age, ignasiAge) {
    if (age > ignasiAge) {
        return 'Ignasi is younger than you';
    } else if (age < ignasiAge) {
        return 'Ignasi is older than you';
    } else {
        return 'You have the same age as Ignasi ';
    }
}

console.log(myname);
console.log(age);
console.log(ageDiff);
console.log(soyMayorDe(age));
console.log(compareAge(age));
/*DOS*/

/*TRES*/
var names = ["David", "Rocio Rodriguez", "Satock33", "Daniel Caceres", "Cristian Daniel", "FreddyBrito", "Christian Kevin Argento", "Nicolás Miszezun", "Evelynjgr", "Mariano", "Carla Ribeiro", "Laura", "Micaela Viva", "Caro Romero", "Christian Daniel", "Damian Cordero", "Ecoraita", "Florencia Gatti", "Jesus Rodriguez", "Juan Ignacio", "Juanma Aramayo", "Maria Bordaolivera", "Natalia Nayla Alvarez", "Nicolas Guallini", "Santiago Lofiego","Sebastian E","Sherly","Silvia","Sol Espejo","Diana Ojeda","UlisesDeKorn"];
 
//ejercicio 1
names.sort();
console.log(names[0]);
console.log(names[names.length-1]);
  for (var i = 0; i < names.length; i++) {
      console.log(names[i]);
  }
//ejercicio1
//ejercicio 2
var edad=[22,23,24,24,24,24,17,40,35,65,42,12,53];
var j;
for(j=0;j<edad.length-1;j++)
    { 
    console.log(edad[j]);
    }


for(j=0;j<edad.length-1;j++)
    {   
        if(edad[j]%2==0)    
        {
            console.log(edad[j]);
        }
        
    }
var g=0;
/*while(g<edad.length)
    {
         if(edad[g]%2==0)    
        {
            console.log(edad[g]);
        }
        g++;
    }*/
 
//ejercicio 2
// ejercicio 3
var minimo=0;
function numeroMinimo(arreglo){
   minimo=arreglo[0];
  for(var z=0;z<=numeroMinimo.length;z++){
     if (arreglo[z] < minimo)
    {
        minimo = arreglo[z];
    }
     
}
 return minimo;
}
console.log(numeroMinimo(arreglo=[5,10,25,58,12]));
 
//ejercicio 3
//ejercicio 4
 
var maximo=0;
function numeroMaximo(arreglo1){
   
        
  for(var z=0;z<=arreglo.length;z++){
     if (arreglo1[z] > maximo)
    {
        maximo = arreglo1[z];
    }
     
}
 return maximo;
}
console.log(numeroMaximo(arreglo1=[5,10,25,58,12]));
 
//ejercicio 4
//ejercicio 5
function indice(edad,index){
   return edad[index];
    
}
console.log(indice(edad=[25,40,75,15],index=2));
//ejercicio 5
//ejercicio 6
function arrRepeat(arr){
var sortArr = arr.slice().sort();
var results = [];
for (var i = 0; i < sortArr.length - 1; i++) {
    if (sortArr[i + 1] == sortArr[i]) {
        results.push(sortArr[i]);
    }
    
}
    console.log(results);
}
arrRepeat(arr = [1, 1, 5, 3, 7, 8, 11, 2, 11]);

//ejercicio 6
//ejercicio 7
var  mycolor = ["Red", "Green", "White", "Black"];
function mostrarColor(mycolor){
   
    var mostrar=mycolor[0];
    for(var z=1;z<mycolor.length;z++)
        {
            mostrar=mostrar+" "+mycolor[z];
        }
    return mostrar;
}
console.log(mostrarColor(mycolor));
/*TRES*/ 
/*CUATRO*/
//ejercicio 1
function invertirDigitos(numero) {
    var invertido = 0
    var resto = numero
    do {
        invertido = invertido * 10 + (resto % 10)
        resto = Math.floor(resto / 10)
    } while (resto > 0)
    return invertido
}
console.log(invertirDigitos(123456));
//ejercicio 1
//ejercicio 2
var cadenaInvertida;

function invertirTexto(cadena) {
    cadenaInvertida = cadena.replace(/[0123456789.*+?^${}()|[\]\\]/g, '');
    return cadenaInvertida;
}

console.log(invertirTexto("qwe222rt..."));
//ejercicio 2
//ejercicio 3
function firsLetter(oracion) {
    return oracion.replace(/^([a-z\u00E0-\u00FC])|\s+([a-z\u00E0-\u00FC])/g, function ($1) {
        return $1.toUpperCase();
    });
}

console.log(firsLetter("hola mundo"));
//ejercicio 3
//ejercicio 4
function buscaPalabraMasLarga(s) {
    palabra_mas_grande = ""
    palabras = s.replace(",", " ").split(" ");
    palabras.forEach(function (palabra) { //Recorro el foreach y dejo la palabra mas grande en palabra_mas_grande
        if (palabra.length > palabra_mas_grande.length) {
            palabra_mas_grande = palabra
        };
    });
    return palabra_mas_grande
}
console.log(buscaPalabraMasLarga("hola todo bien como estan"));

//ejercicio 4
/*CUATRO*/