namespace Ch11_02_Sorting.Models
{
    public class IndexViewModel
    {
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public SortViewModel SortViewModel { get; set; } = new SortViewModel(SortState.NameAsc);
    }
}
