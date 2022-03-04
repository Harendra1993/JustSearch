namespace JustSearch.Api.Models.DTOs
{
    public class SearchDTO
    {
        public string OrderResults { get; set; }
        public string SortResults { get; set; }
        public string SearchOption { get; set; }
        public string UserInput { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
