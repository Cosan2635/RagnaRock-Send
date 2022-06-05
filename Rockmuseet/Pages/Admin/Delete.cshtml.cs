using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rockmuseet.Interfaces;
using Rockmuseet.models;

namespace Rockmuseet.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public History History { get; set; }
        private IHistoryRepository historyRepository;

        public DeleteModel(IHistoryRepository repository)
        {
            historyRepository = repository;
        }

        public IActionResult OnGet(int id)
        {
            History = historyRepository.GetHistory(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            historyRepository.DeleteHistory(History);
            return RedirectToPage("Index");
        }
    }
}
