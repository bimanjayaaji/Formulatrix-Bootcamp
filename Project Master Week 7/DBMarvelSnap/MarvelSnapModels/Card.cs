using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MarvelSnapDB;

public partial class Card
{
    [Key]
    [Column("OwnerID")]
    public long OwnerId { get; set; }

    [Column("CardID")]
    public long? CardId { get; set; }

    [Column("PlayerID")]
    public long? PlayerId { get; set; }

    public string CardName { get; set; } = null!;

    [ForeignKey("PlayerId")]
    [InverseProperty("Cards")]
    public virtual Player? Player { get; set; }
}
