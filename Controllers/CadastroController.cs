using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopem.Enums;
using RoleTopem.Models;
using RoleTopem.Repositories;
using RoleTopem.ViewModels;
using RoleTopMVC.Controllers;
using RoleTopMVC.ViewModels;

namespace RoleTopem.Controllers
{
        public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["endereco"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse(form["data-nascimento"]));

                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                
                clienteRepository.Inserir(cliente);
                
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}