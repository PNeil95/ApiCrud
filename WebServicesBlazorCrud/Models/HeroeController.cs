using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//usando respuesta
using WebServicesBlazorCrud.Models.Response;
//usando models
using WebServicesBlazorCrud.Models;
using WebServicesBlazorCrud.Models.Request;

namespace WebServicesBlazorCrud.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroeController : ControllerBase
    {
        [HttpGet]
        //interfaz para regresar contenido
        public IActionResult Add()
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    var lst = db.Heroes.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }

            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpPost]
        //interfaz para regresar contenido
        public IActionResult Get(HeroeRequest models)
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    Heroe oHeroe = new Heroe();
                    oHeroe.Nombre = models.Nombre;
                    oHeroe.Poder = models.Poder;
                    oHeroe.Universo = models.Universo;
                    db.Heroes.Add(oHeroe);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }

            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpPut]
        //interfaz para regresar contenido
        public IActionResult Edit(HeroeRequest models)
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    Heroe oHeroe = db.Heroes.Find(models.Id);
                    oHeroe.Nombre = models.Nombre;
                    oHeroe.Poder = models.Poder;
                    oHeroe.Universo = models.Universo;
                    db.Entry(oHeroe).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }

            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpDelete("{Id}")]
        //interfaz para regresar contenido
        public IActionResult Delete (int Id)
        {
            Respuesta oRespuesta = new Respuesta();

            try
            {
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    Heroe oHeroe = db.Heroes.Find(Id);
                    db.Remove(oHeroe);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }

            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
    }
}
