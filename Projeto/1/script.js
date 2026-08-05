
function verificar() {

    let nome = document.getElementById("nome").value;
    let senha = document.getElementById("senha").value;

    if (nome == "") {
        alert("O campo nome não pode ser deixado em branco");
    }
    if (senha == "") {
        alert("O campo senha não pode ser deixado em branco");
    }

}