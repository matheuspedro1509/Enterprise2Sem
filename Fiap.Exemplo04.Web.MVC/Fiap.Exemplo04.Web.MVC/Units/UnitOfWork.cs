﻿using Fiap.Exemplo04.Web.MVC.Persistencia;
using Fiap.Exemplo04.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Units
{
    public class UnitOfWork :IDisposable
    {
        private FutebolContext _context = new FutebolContext();

        private ITimeRepository _timeRepository;

        private IJogadorRepository _jogadorRepository;

        public ITimeRepository TimeRepository
        {
            get
            {
                if (_timeRepository == null)
                {
                    _timeRepository = new TimeRepository(_context);
                }
                return _timeRepository;
            }
        }

        public IJogadorRepository JogadorRepository
        {
            get
            {
                if(_jogadorRepository == null)
                {
                    _jogadorRepository = new JogadorRepository(_context);
                }
                return _jogadorRepository;
            }
        }

        //Liberar conexão com o banco
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }

    
}