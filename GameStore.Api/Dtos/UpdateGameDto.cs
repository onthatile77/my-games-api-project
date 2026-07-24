using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record UpdateGameDto(
    [Required][StringLength(30)]string Name,
    [Required][StringLength(20)]string Category,
    [Range(0, 200)]decimal Price,
    DateOnly ReleaseDate
);