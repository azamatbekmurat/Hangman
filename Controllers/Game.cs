using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
    public class GameController : Controllers
    {
        [HttpPost("/Game/Create")]
        public ActionResult Create()
        {
            Game.SetCurrentWord(Request.Form["currentWord"]);
            Game myGame = new Game();
            Game.SetDashString();
            return View("Info", myGame);
        }
    }
}