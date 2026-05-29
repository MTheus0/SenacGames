using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Gamecount { get; set; }

    }

    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;

    }

    public class UpdateCategoryDto
    {
        public string Name { get; set; } = string.Empty;

    }
}
