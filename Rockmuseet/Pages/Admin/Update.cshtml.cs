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
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public History History { get; set; }

        private IHistoryRepository historyRepository;

        public UpdateModel(IHistoryRepository repository)
        {
            historyRepository = repository;
        }

        public void OnGet(int id)
        {
            History = historyRepository.GetHistory(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            historyRepository.UpdateHistory(History);
            return RedirectToPage("Index");
        }
    }
}
