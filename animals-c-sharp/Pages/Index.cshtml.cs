using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace animals_c_sharp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        ObservableCollection<Animal> AnimalsCollection = new ObservableCollection<Animal> { };
    }
}
