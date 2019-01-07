namespace DellQnA.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnswerTable")]
    public partial class AnswerTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AID { get; set; }

        public string Answer { get; set; }

        public int UID { get; set; }

        public int QID { get; set; }
    }
}
