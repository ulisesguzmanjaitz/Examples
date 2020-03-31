document.getElementById('formularioTarea').addEventListener('submit', guardarTarea);

function guardarTarea(e) {
  
  let titulo = document.getElementById('titulo').value;
  let descripcion = document.getElementById('descripcion').value;
  console.log(descripcion)

    let tarea = {
      titulo,
      descripcion
    };
  
    if(localStorage.getItem('tareas') === null) {
      let tareas = [];
      tareas.push(tarea);
      localStorage.setItem('tareas', JSON.stringify(tareas));
    } else {
      let tareas = JSON.parse(localStorage.getItem('tareas'));
      tareas.push(tarea);
      localStorage.setItem('tareas', JSON.stringify(tareas));
    }
  
    getTareas();
    document.getElementById('formularioTarea').reset();
  
  
  e.preventDefault();
 
}

function eliminarTarea(titulo) {
  console.log(titulo)
  let tareas = JSON.parse(localStorage.getItem('tareas'));
  for(let i = 0; i < tareas.length; i++) {
    if(tareas[i].titulo == titulo) {
      tareas.splice(i, 1);
    }
  }
  
  localStorage.setItem('tareas', JSON.stringify(tareas));
  getTareas();
}

function getTareas() {
  let tareas = JSON.parse(localStorage.getItem('tareas'));
  let vistaTareas = document.getElementById('tareas');
  vistaTareas.innerHTML = '';
  for(let i = 0; i < tareas.length; i++) {
    let titulo = tareas[i].titulo;
    let descripcion = tareas[i].descripcion;

    vistaTareas.innerHTML += `<div class="card mb-3">
        <div class="card-body">
          <p>${titulo} - ${descripcion}
          <a href="#" onclick="eliminarTarea('${titulo}')" class="btn btn-danger ml-5">Eliminar</a>
          </p>
        </div>
      </div>`;
  }
}

getTareas();
