namespace Ch03_04_Inject
{
    public class SimpleTimeService : ITimeService
    {
        public string Time => DateTime.Now.ToShortTimeString();
    }
}
