using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetCoreVS.Data;
using ApiNetCoreVS.Models;
using Microsoft.EntityFrameworkCore;
using ApiNetCoreVS.Helpers;
using System.IO;
using Newtonsoft.Json;

namespace ApiNetCoreVS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TxtFileController : Controller
    {
        private readonly Context _context;
        private readonly IFileHelper _fileHelper;

        public TxtFileController(Context _context, IFileHelper _fileHelper)
        {
            this._context = _context;
            this._fileHelper = _fileHelper;
        }


        // GET: TxtFileController
        [HttpGet]
        public ActionResult Index()
        {
            var output = _context.TxtFiles.ToListAsync<TxtFile>().Result;
            return CreatedAtAction("Index", output);
        }

        //GET: TxtFileController/Details/5
        [HttpGet("{id:int}")]
        public ActionResult Details(int id)
        {
            var result = _context.TxtFiles.FirstOrDefaultAsync<TxtFile>(c => c.Id == id).Result;
            return CreatedAtAction("Details", result);
        }


        // GET: TxtFileController/Create
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create([FromBody] TxtFile txtFile)
        {
            StreamReader stream = new StreamReader(Request.Body);
            //string body = stream.ReadToEndAsync().Result;
            //dynamic json =JsonConvert.DeserializeObject(body);

            //string file = json.file.Value as string;
            //string fileType = json.type.Value as string;

            //string base64 = _fileHelper.Base64Encode(file);

            _context.TxtFiles.Add(txtFile);
            var result = _context.SaveChanges();
            return CreatedAtAction("Create", result);
        }

        // POST: TxtFileController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: TxtFileController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: TxtFileController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: TxtFileController/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TxtFileController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
