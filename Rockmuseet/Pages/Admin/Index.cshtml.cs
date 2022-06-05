using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Rockmuseet.Interfaces;
using Rockmuseet.models;

namespace Rockmuseet
{
    public class AdminModel : PageModel
    {
        private IHistoryRepository historyRepository;
        public AdminModel(IHistoryRepository repository)
        {
            historyRepository = repository;
        }
        public Dictionary<int, History> Histories { get; private set; }

        [BindProperty]
        public History History { get; set; }


        public IActionResult OnGet()
        {
            Histories = historyRepository.GetAllHistories();
            return Page();
        }
    }
}
