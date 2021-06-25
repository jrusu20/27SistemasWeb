
class Cursos extends Uploadpicture {

    RegistrarCurso() {

        var data = new FormData();
        data.append('Input.Nombre', $('#curNombre').val());
        data.append('Input.Descripcion', $('#curDescripcion').val());
        data.append('Input.Horas', $('#curHoras').val());
        data.append('Input.Costo', $('#curCosto').val());
        data.append('Input.Estado', $('#curEstado').val());
        data.append('Input.CategoriaID', $('#curCategoria').val());
        $.each($('input[type=file]')[0].files, (i, file) => {
            data.append('AvatarImage', file);
        });

    }

}
