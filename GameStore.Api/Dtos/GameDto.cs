namespace GameStore.Api.Dtos;

public record GameDto(
    int Id,
    string Name,
    string Category,
    decimal Price,
    DateOnly ReleaseDate
);