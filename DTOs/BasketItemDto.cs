using System;

namespace API.DTOs;

public class BasketItemDto
{
    public int ProductId { get; set; }

    public required string Name { get; set; }
    public required string Description { get; set; }

    public long Price { get; set; }

    public required string PictureUrl { get; set; }

    public required string Type { get; set; }

    public required string Brand { get; set; }

    public int Quantity { get; set; }
}
