﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento =  new Evento[]{
                new Evento (){
                    EventoId = 1,
                    Tema = "Angular 11 e .Net 5",
                    Local = "Batatais-SP",
                    Lote = "1º Lote",
                    QtdePessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new Evento (){
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "Franca-SP",
                    Lote = "2º Lote",
                    QtdePessoas = 320,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
           };
        public EventoController() {
          
        }

        [HttpGet]
        public IEnumerable<Evento> Get() {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id) {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post(){
            return "Exemplo de Post";

        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Exemplo de Delete com id = {id}";
        }
    }

}
