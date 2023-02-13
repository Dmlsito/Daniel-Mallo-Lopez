const container = document.querySelector(".containerMain")

const materias = [
    {
        name: "Bases de datos",
        note: 8
    },
    {
        name: "Sistemas informaticos",
        note: 10
    },
    {
        name: "Programacion2",
        note: 6
    },
    {
        name: "Calculo1",
        note: 7
    },
    {
        name: "Fisica",
        note: 9
    },
    {
        name: "Sistema empresarial",
        note: 4
    },
    {
        name: "Gestion empresarial",
        note: 10
    }
]

const obtenerNotas = (id) => {
    return new Promise((resolve, reject) => {
      let materia = materias[id];
      if(materia == undefined){
        reject("No se ha encontrado la nota")
      }else{
        setTimeout(() => {
          resolve(materia)
        }, Math.random() * 1400)
      }
    })
}

const mostrarNotas = async () => {
    let resultado = []

    for(let i = 0; i<materias.length; i++){
        resultado[i] = await obtenerNotas(i);

        let innerHtml = `<p class = "nombre">${resultado[i].name}</p>
        <p class = "nota">${resultado[i].note}</p>`

        container.innerHTML += innerHtml
    }
}

mostrarNotas();