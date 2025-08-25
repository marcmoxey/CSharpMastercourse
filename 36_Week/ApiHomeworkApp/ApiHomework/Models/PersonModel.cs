namespace ApiHomework.Models
{
    public class PersonModel
    {

       
        
            public string Message { get; set; }
            public ResultModel Result { get; set; }
            public string ApiVersion { get; set; }
            public DateTime Timestamp { get; set; }
            public SupportModel Support { get; set; }
            public SocialModel Social { get; set; }
        

    }
}
