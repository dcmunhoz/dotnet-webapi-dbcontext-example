using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.Models;


namespace webapi.Controllers 
{
    [Route("/api/vi/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly DataContext db;

        public FuncionariosController(DataContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public string Get()
        {
            return "Olá mundo !!! Estou funcionando =D";
        }

        [HttpGet("listar")]
        public List<Funcionario> Listar()
        {

            List<Funcionario> func = db.funcionarios.OrderBy(func => func.nome).ToList();
            
            return func;
            
        }

    }
}