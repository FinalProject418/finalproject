using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class Todo
    {
      
        public int ID { get; set; }
        [Display(Name = "Diagnosis")]
        public string Description { get; set; }
       
        public string filler = "Jeff Yates";
        [Display(Name = "Supervising Physician")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        public bool Done { get; set; }
        [Display(Name = "Description")]

        //[Dis]



        public string Name1 { get; set; }
        [Display(Name = "First Name")]
        public string Name2 { get; set; }
        [Display(Name = "Middle Name")]
        public string Name3 { get; set; }
        [Display(Name = "Last Name")]
        public string Name4 { get; set; }
        [Display(Name = "Address")]
        public string Name5 { get; set; }
        [Display(Name = "Gender")]
        public string Name6 { get; set; }
        [Display(Name = "Symptoms")]
        public string Name7 { get; set; }
       


    }

}