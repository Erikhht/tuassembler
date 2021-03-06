﻿function DisponibilidadController(contenedor) {
    this.SystemType = 'DisponibilidadController';
    var self = this;
    this.recurso = null;
    this.datosSinGuardar = false;
    
    var nuevaFila = '<tr> \
                        <td><input type="text" ></td> \
                        <td><input type="text" ></td> \
                        <td><input type="text" ></td> \
                        <td><input type="text" ></td> \
                        <td><input type="text" ></td> \
                        <td><input type="text" ></td> \
                        <td><input type="text" ></td> \
                    </tr>';
    
    var obtFila = function ($input) {
        return $input.parent().parent().prevAll().length;
    };

    this.editar = function () {
        self.recurso.recorrerDisponibilidad(function (dispoFila) {
            var info = new {
                lu: dispoFila[0],
                ma: dispoFila[1],
                mi: dispoFila[2],
                ju: dispoFila[3],
                vi: dispoFila[4],
                sa: dispoFila[5],
                dom: dispoFila[6]
            };
            agregarDisponibilidad(info);
        });
    };

    var agregarDisponibilidad = function (info) {
        var $nuevaFila = $.tmpl(RecursoPlantilla.FilaDisponibilidad, info);
        var $tabla = $('#disponibilidad', contenedor);
        $nuevaFila.find('input').blur(actualizarHorarioConBlur).keypress(actualizarHorarioConEnter);
        $tabla.find('tbody').append($nuevaFila);
    };
    
    this.extraerInfo = function () {
        var $tabla = $('#disponibilidad', contenedor);
        for (var dia = 1; dia <= 7; dia++) {
            $tabla.find('tr td:nth-child(' + dia + ') input').each(function (ind, input) {
                var val = $(input).val();
                if(val!='') {
                    var rango = new Rango(val);
                    self.recurso.agregarDisponibilidad(dia, rango.inicio, rango.fin);    
                }
            });
        }
    };

    this.limpiarPantalla = function () {
        $('#disponibilidad', contenedor).find('tr:gt(1)').remove();
        $('#disponibilidad input', contenedor).val('');
        $('#disponibilidad input:first', contenedor).focus();

        self.datosSinGuardar = false;
    };
    
    var obtCol = function($input) {
        return $input.parent().prevAll().length;
    };

    var actualizarHorario = function ($input) {
        $input = obtenerPrimerEspacioNoVacio($input);

        var valor = $input.val();

        if (valor != '') {
            self.datosSinGuardar = true;
            var horarioValido = validarHorario($input);
            if (horarioValido[0]) {
                intercambiar($input, horarioValido[1]); //ordenar el nuevo rango en la fila                    
                self.datosSinGuardar = true;
            }
        }
        else {
            $("#error", contenedor).text('');
            $input.toggleClass('invalid-input', false);
        }

        manejarFilaVacia();
    };

    var manejarFilaVacia = function () {
        var celdaVacia = function (td) {
            return $(td).find('input').val() == '';
        };

        var $tabla = $('#disponibilidad', contenedor);
        var ultimaFilaVacia = $tabla.find('tr:last td').toArray().every(celdaVacia);
        var ultimas2FilasVacias = $tabla.find('tr').slice(-2).find('td').toArray().every(celdaVacia);

        if (ultimas2FilasVacias)
            $tabla.find('tr:last').remove();
        else
            if (!ultimaFilaVacia) {
                var $nuevaFila = $(nuevaFila);
                $nuevaFila.find('input').blur(actualizarHorarioConBlur).keypress(actualizarHorarioConEnter);
                $tabla.find('tbody').append($nuevaFila);
            }
    };

    var obtenerPrimerEspacioNoVacio = function ($input) {
        var fila = obtFila($input);
        var col = obtCol($input);
        var $tbody = $input.parent().parent().parent();

        var $nuevoInput = null;
        var valor = '';
        var cambiar = false;

        do {
            fila--;
            var nuevoInput = $tbody.find('tr::nth-child(' + (fila + 1) + ') td:nth-child(' + (col + 1) + ') input');
            valor = nuevoInput.val();
            if (valor == '') {
                $nuevoInput = nuevoInput;
                cambiar = true;
            }
        }
        while (valor == '')

        if (cambiar) {
            $nuevoInput.val($input.val());
            $input.val('');
        }

        return cambiar ? $nuevoInput : $input;
    };

    var verificarValor = function ($input, rango) {
        var fila = obtFila($input);
        var col = obtCol($input);
        var $tbody = $input.parent().parent().parent();

        var horsColumna = $tbody.find('tr td:nth-child(' + (col + 1) + ') input').toArray();
        var horariosColumna = [];
        horsColumna.forEach(function (horario) {
            var val = $(horario).val();
            if (val != '')
                horariosColumna.push($(horario).val());
        });

        var solapa = rango.seSolapaConAlguno(fila, horariosColumna);
        var vaEnLaFila = rango.ordenar(fila, horariosColumna);
        return { seSolapa: solapa, intercambiar: { columna: col, fila: fila, vaEnLaFila: vaEnLaFila} };
    };

    var validarHorario = function ($input) {
        var rango = new Rango();
        var infoNuevoValor = null;
        var todoBien = rango.asignar($input.val());
        if (todoBien) {
            infoNuevoValor = verificarValor($input, rango);
            todoBien = !infoNuevoValor.seSolapa;
            if (todoBien) {
                $("#error", contenedor).text('');
                $input.toggleClass('invalid-input', false);
            }
            else {
                $input.toggleClass('invalid-input', true);
                $("#error", contenedor).text('*Ese horario se solapa con uno existente.');
            }

        } else {
            $input.toggleClass('invalid-input', true);
            $("#error", contenedor).text('*Ingrese un rango válido.');
        }

        return [todoBien, infoNuevoValor];
    };

    var intercambiar = function ($input, infoNuevoValor) {
        var $tbody = $input.parent().parent().parent();
        var intercambio = infoNuevoValor.intercambiar;
        var valorNuevo = $input.val();

        if (intercambio.vaEnLaFila != intercambio.fila) {
            var desde = intercambio.vaEnLaFila;
            var valor = '';
            valor = valorNuevo;
            
            if (desde < intercambio.fila) 
                while (desde < intercambio.fila) {
                    var $input2 = $tbody.find('tr:nth-child(' + (desde + 1) + ') td:nth-child(' + (intercambio.columna + 1) + ') input');
                    var valor2 = $input2.val();
                    $input2.val(valor);
                    valor = valor2;
                    desde++;
                }            
            else 
                while (desde > intercambio.fila) {
                    var input2 = $tbody.find('tr:nth-child(' + (desde + 1) + ') td:nth-child(' + (intercambio.columna + 1) + ') input');
                    var val2 = input2.val();
                    input2.val(valor);
                    valor = val2;
                    desde--;
                }
                       
            $input.val(valor);
        }
    };

    var actualizarHorarioConEnter = function (e) {
        if (e.which == 13)
            actualizarHorario($(this));
    };

    var actualizarHorarioConBlur = function () {
        actualizarHorario($(this));
    };
    
    this.inicializar = function () {
        $('td input', contenedor).blur(actualizarHorarioConBlur).keypress(actualizarHorarioConEnter);
    };
};