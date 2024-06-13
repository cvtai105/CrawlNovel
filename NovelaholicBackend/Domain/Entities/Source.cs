using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Source
{
    public int Id { get; set; }
    [Required]
    [MaxLength(255)]
    public Url HostURL { get; set; } = new Url(string.Empty);
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(255)]
    public Url BooklistURL { get; set; } = new Url(string.Empty);
    [Required]
    [MaxLength(50)]
    public string ContentElementId { get; set; } = string.Empty;
    public List<Novel> Novels { get; set; } = new List<Novel>();
}