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
    public class JogadorRepository : IJogadorRepository
    {
        private FutebolContext _context;

        public JogadorRepository(FutebolContext _context)
        {
            this._context = _context;
        }

        public void Atualizar(Jogador jogador)
        {
            _context.Entry(jogador).State = EntityState.Modified;
        }

        public Jogador Buscar(int codigo)
        {
            return _context.Jogadores.Find(codigo);
        }

        public List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro)
        {
            return _context.Jogadores.Include("Time").Where(filtro).ToList();
        }

        public void Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
        }

        public List<Jogador> Listar()
        {
            return _context.Jogadores.Include("Time").ToList();
        }

        public void Remover(int codigo)
        {
            Jogador jogador = _context.Jogadores.Find(codigo);
            _context.Jogadores.Remove(jogador);
        }
    }
}