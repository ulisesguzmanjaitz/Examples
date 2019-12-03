/*Atajos al DOM*/
/*Forum*/
var postTitle = document.getElementById('postTitle');
var postBody = document.getElementById('postBody');
var btnSubmit = document.getElementById('btnSubmit');
var postArea = document.getElementById('posts');

/*Login*/
var loginEmail = document.getElementById('email');
var loginPassword = document.getElementById('password');
var btnLogin = document.getElementById('btnLoginWEmail');
var btnLoginWGoogle = document.getElementById('btnLoginWGoogle');
var btnLoginWFacebook = document.getElementById('btnLoginWFacebook');

/*SignUp*/
var signUpNickname = document.getElementById('signUpNickname');
var signUpEmail = document.getElementById('signUpEmail');
var signUpPassword = document.getElementById('signUpPassword');
var signUpPasswordCheck = document.getElementById('signUpPasswordCheck');
var btnSignUp = document.getElementById('btnSignUp');


/*SignOut*/
var btnSignout = document.getElementById('btnSignOut');
/************************************************************************************/

/*Escritura de datos*/
btnSubmit.addEventListener('click', function() {
  var title = postTitle.value;
  var body = postBody.value;

  firebase.database().ref('test').push({
    titulo: title,
    cuerpo: body
  });
});
/************************************************************************************/

/*Lectura de datos y actualización de mensajes*/
firebase.database().ref('test').on('value', function(snapshot) {
  var html = '';
  postArea.innerHTML = html;
  snapshot.forEach(function(e) {
    var element = e.val();
    var titulo = element.titulo;
    var cuerpo = element.cuerpo;
    html += '<li class="list-group-item"><p>Titulo:'+titulo+'</p><p>Mensaje:'+cuerpo+'</p></li>'
  });
  postArea.innerHTML += html;
});
/************************************************************************************/

/*Creación de cuenta*/
btnLogin.addEventListener('click', function() {
  var userEmail = loginEmail.value;
  var userPassword = loginPassword.value;
  firebase.auth().createUserWithEmailAndPassword(userEmail, userPassword).catch(function(error) {
    var errorCode = error.code;
    var errorMessage = error.message;
    /*Hacer Algo*/
  });
});
/************************************************************************************/

/*Signout*/
btnSignOut.addEventListener('click' , function() {
  firebase.auth().signOut().then(function() {
    // Sign-out successful.
  }).catch(function(error) {
    // An error happened.
  });
});
