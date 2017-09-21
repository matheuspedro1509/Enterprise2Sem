﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo04.Web.MVC.Models;
using Fiap.Exemplo04.Web.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.Exemplo04.Web.MVC.Repositories
{
    public class TimeRepository : ITimeRepository
    {

        private FutebolContext _context;

       public TimeRepository(FutebolContext context)
        {
            _context = context;
        }


        public void Atualizar(Time time)
        {
            _context.Entry(time).State = EntityState.Modified;
        }

        public Time Buscar(int codigo)
        {
           return _context.Times.Find(codigo);
        }

        public List<Time> BuscarPor(Expression<Func<Time, bool>> filtro)
        {
            return _context.Times.Include("Tecnico").Where(filtro).ToList();
        }

        public void Cadastrar(Time time)
        {
            _context.Times.Add(time);
        }

        public List<Time> Listar()
        {
            return _context.Times.Include("Tecnico").ToList();
        }

        public void Remover(int codigo)
        {
            Time time = _context.Times.Find(codigo);
            _context.Times.Remove(time);
        }
    }
}