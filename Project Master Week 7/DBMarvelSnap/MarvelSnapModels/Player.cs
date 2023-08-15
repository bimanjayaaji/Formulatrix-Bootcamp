using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MarvelSnapDB;

public partial class Player
{
    [Key]
    [Column("PlayerID")]
    public long PlayerId { get; set; }

    public string PlayerName { get; set; } = null!;

    [InverseProperty("Player")]
    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();
}
