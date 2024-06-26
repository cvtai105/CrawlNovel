using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public class Source
{
    public int Id { get; set; }
    [Required]
    [MaxLength(255)]
    public string HostURL { get; set; } = String.Empty; 
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(255)]
    public string NovelListUrl { get; set; } = String.Empty; 
    [Required]
    [MaxLength(255)]
    public string GenreUrl { get; set; } = String.Empty; 
    [Required]
    [MaxLength(255)]
    public string HotNovelUrl { get; set; } = String.Empty; 
    [Required]
    [MaxLength(50)]
    public string ContentElementId { get; set; } = string.Empty;
    public List<Novel> Novels { get; set; } = [];
}