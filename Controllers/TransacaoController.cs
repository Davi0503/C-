using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using  Senai.transacao.Models;
using System;


namespace Senai.transacao.Controllers {
    public class TransacaoController : Controller {

        [HttpGet]
        public ActionResult Cadastrar () {

            return View ();

        }

        [HttpPost]

        public ActionResult Cadastrar (IFormCollection form) {


            

            TrasacaoModel transacao = new TrasacaoModel();

            transacao.Descricao = form["descricao"];
            transacao.Valor = double.Parse(form["valor"]);
            transacao.Tipo = form["tipo"];
            transacao.DataTransacao = DateTime.Parse(form["datatransacao"]);
            
            using(StreamWriter sw = new StreamWriter("transacoes.csv", true)){
                sw.WriteLine($"{transacao.Descricao}{transacao.Valor}{transacao.Tipo}{transacao.DataTransacao}");

            }

            return View();
        }
    }
}