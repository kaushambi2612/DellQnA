namespace DellQnA.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionTable")]
    public partial class QuestionTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QID { get; set; }

        public string Question { get; set; }

        [StringLength(10)]
        public string UID { get; set; }
    }
}
