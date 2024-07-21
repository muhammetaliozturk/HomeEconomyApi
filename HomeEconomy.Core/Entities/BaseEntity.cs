using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeEconomyApi.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Kayıt Numarası")]
        public int Id { get; set; }

        [Required]
        [Description("Kayıt Aktif Mi?")]
        public bool IsActive { get; set; }

        [Required]
        [Description("Oluşturma Tarihi")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Description("Oluşturan Kullanıcı")]
        public int CreateUserId { get; set; }

        [Description("Silme Tarihi")]
        public DateTime? UpdateDate { get; set; }

        [Description("Silen Kullanıcı")]
        public int? UpdateUserId { get; set; }

        [Description("Güncelleme Tarihi")]
        public DateTime? DeleteDate { get; set; }

        [Description("Güncelleyen Kullanıcı")]
        public int? DeleteUserId { get; set; }
    }
}
