﻿using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories
{
    public class CreateCategoryRequest : Request
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Título")]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Description { get; set; } = string.Empty;
    }
}
