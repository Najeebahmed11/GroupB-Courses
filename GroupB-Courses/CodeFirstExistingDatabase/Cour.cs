namespace CodeFirstExistingDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Security.AccessControl;

    public partial class Cour
    {
        [Key]
        public int CourseID { get; set; }

        public int AuthorID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public short Price { get; set; }

        public string LevelString { get; set; }

        public byte Level { get; set; }

        public virtual Author Author { get; set; }
    }
}
