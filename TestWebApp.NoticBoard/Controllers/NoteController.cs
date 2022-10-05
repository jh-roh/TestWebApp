using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestWebApp.NoticBoard.DataContext;
using TestWebApp.NoticBoard.Models;

namespace TestWebApp.NoticBoard.Controllers
{
    public class NoteController : Controller
    {
        private NoticeBoardDbContext _DbContext;

        public NoteController(NoticeBoardDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        /// <summary>
        /// 게시판 리스트 출력
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                //로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }

            var list = _DbContext.Notes.ToList();
            
            return View(list);
        }

        /// <summary>
        /// 게시판 상세
        /// </summary>
        /// <param name="noteNo"></param>
        /// <returns></returns>
        public IActionResult Detail(int noteNo)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                //로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }

            var note = _DbContext.Notes.FirstOrDefault(p => p.NoteNo.Equals(noteNo));

            return View(note);
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Note model)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                //로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }

            model.UserNo = (int)HttpContext.Session.GetInt32("USER_LOGIN_KEY");

            if (ModelState.IsValid)
            {
                _DbContext.Notes.Add(model);

                if(_DbContext.SaveChanges() > 0) //Commit
                {
                    return Redirect("Index");
                }
                ModelState.AddModelError(string.Empty, "게시물을 저장할 수 없습니다.");
            }

            return View(model);
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                //로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Detete()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                //로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

    }
}
