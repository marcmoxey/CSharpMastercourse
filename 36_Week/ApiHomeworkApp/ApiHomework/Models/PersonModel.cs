namespace ApiHomework.Models
{
    public class PersonModel
    {
        public string message { get; set; }
        public ResultModel result { get; set; }
        public string apiVersion { get; set; }
        public DateTime timestamp { get; set; }
        public SupportModel support { get; set; }
        public SocialModel social { get; set; }
    }



}
