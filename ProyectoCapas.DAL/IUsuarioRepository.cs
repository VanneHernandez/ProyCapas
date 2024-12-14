﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.DAL
{
    public interface IUsuarioRepository
    {
        List<Usuario> obtenerTodos();
        Usuario ObtenerPorId(int id);
        void Agregar(Usuario usuario);
        void Actualizar(Usuario usuario);
        void Eliminar(int id);
    }
}
