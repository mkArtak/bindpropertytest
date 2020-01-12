using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace BindPropertyTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public bool Test1 { get; set; }

        [BindProperty]
        public bool Test2 { get; set; }

        public IActionResult OnGet()
        {
            Test1 = false;
            Test2 = false;

            return Page();
        }

        public IActionResult OnPost()
        {
            Console.WriteLine("Test1: {0}", Test1);
            Console.WriteLine("Test2: {0}", Test2);

            Test1 = !Test1;
            Test2 = !Test2;

            return Page();
        }
    }
}
