using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_LoggingExcepion_with_ExceptionFilter.Models
{
    public class ExceptionLogger
    {
        [Key]
        public int Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ControllerName{ get; set; }
        public string ExceptionStackTrace { get; set; }
        public DateTime LogTime { get; set; }

    }
}