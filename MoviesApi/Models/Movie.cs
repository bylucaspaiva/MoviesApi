using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models;

public class Movie
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "The title is required.")]
    public string Title {  get; set; }
    [Required(ErrorMessage = "The genre is required.")]
    [MaxLength(50, ErrorMessage = "Max size of genre is 50 caracters")]
    public string Genre { get; set; }
    [Required]
    [Range(70, 300, ErrorMessage = "Duration must be between 70 min and 300 min.")]
    public int Duration { get; set; }
}
