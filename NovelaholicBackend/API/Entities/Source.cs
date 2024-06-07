using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
public class Source
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(255)]
    public string HostURL { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(255)]
    public string BooklistURL { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string ContentElementId { get; set; } = string.Empty;
    public List<Novel> Novels { get; set; } = new List<Novel>();
}