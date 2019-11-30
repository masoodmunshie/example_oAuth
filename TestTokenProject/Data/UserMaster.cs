namespace TestTokenProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMaster")]
    public partial class UserMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }

        [StringLength(500)]
        public string UserRoles { get; set; }

        [StringLength(100)]
        public string UserEmailID { get; set; }
    }
}
