﻿namespace WebUI.Dtos.FeedbackDto
{
    
    public class CreateFeedbackDto
    {
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool Status { get; set; }
    }
}
