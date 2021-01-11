var ValidaExclusao = function (id, evento) {

    if (confirm("confirmar exclusão?")) {
        return true;
    }
    else {
        evento.preventDefault();
        return false;
    }
}