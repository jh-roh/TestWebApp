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

            var list = _DbContext.Notes.ToList();
            
            return View(list);
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
            if(ModelState.IsValid)
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
            return View();
        }

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Detete()
        {
            return View();
        }
    }
}
