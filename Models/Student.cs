using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }
        [Key]
        public int ID { get; set; }
        [DisplayName("苗字")]
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [MaxLength(10, ErrorMessage = "BloggerName must be 10 characters or less"), MinLength(5)]
        public string FirstMidName { get; set; }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }
    }
}
