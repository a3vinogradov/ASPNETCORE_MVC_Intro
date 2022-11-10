using Ch05_02_ViewModel.Models;

namespace Ch05_02_ViewModel.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Person> People { get; set; } = new List<Person>();
        public IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
    }
}
