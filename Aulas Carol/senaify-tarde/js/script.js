//Pegar elementos do HTML pelo id
var botao = document.getElementById("botao");
var fundo = document.getElementById("fundo");
var fechar = document.getElementById("fechar");


//Acionar eventos exemplo onClick
botao.onclick = function() {
    fundo.classList.add("visivel");
}

fechar.onclick = function() {
    fundo.classList.remove("visivel");
}