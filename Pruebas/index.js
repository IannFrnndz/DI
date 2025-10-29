let miFormulario = document.getElementById("miFormulario")
console.log(miFormulario)

miFormulario.addEventListener('submit', (e)=> {
    
    e.preventDefault() // evita recargar la página

    miFormulario.style.background="red";
})