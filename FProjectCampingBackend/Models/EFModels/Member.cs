namespace FProjectCampingBackend.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            Orders = new HashSet<Order>();
        }

		[Display(Name = "�s��")]
		public int Id { get; set; }

		[Display(Name = "�b��")]
		[Required]
        [StringLength(50)]
        public string Account { get; set; }


        [Required]
        [StringLength(70)]
        public string Password { get; set; }

		[Display(Name = "�m�W")]
		[Required]
        [StringLength(30)]
        public string Name { get; set; }


        [Required]
        [StringLength(256)]
        public string Email { get; set; }

		[Display(Name = "�q��")]
		[Required]
        [StringLength(10)]
        public string PhoneNum { get; set; }

		[Display(Name = "�ͤ�")]
		public DateTime Birthday { get; set; }

		[Display(Name = "�O�_���v")]
		public bool Enabled { get; set; }

		[Display(Name = "�Ӥ�")]
		[StringLength(1000)]
        public string Photo { get; set; }

		[Display(Name = "�إ߮ɶ�")]
		public DateTime CreatedTime { get; set; }

		[Display(Name = "�O�_����")]
		public bool? IsConfirmed { get; set; }

        [StringLength(50)]
        public string ConfirmCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
