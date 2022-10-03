using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAQApplication.Models
{
    public class FAQ
    {
        
        
        public string FaqID { get; set; }

        public string Question { get; set; }

        public Category Category { get; set; }

        public Topic Topic { get; set; }

        public string Answer { get; set; }
        
        
    }
}
