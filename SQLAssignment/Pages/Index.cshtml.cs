using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SQLAssignment.Pages
{
    public class IndexModel : PageModel

        private IDBService _service;
    public IndexTitlesModel(IDBService service)
    {
        _service = service;
    }

    public List<Titles> Title { get; set; }
    public void OnGet() {

        Title = _service.GetAllTitles();

    }
        
   
}
