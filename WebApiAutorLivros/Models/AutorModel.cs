﻿using System.Text.Json.Serialization;

namespace WebApi8_Video.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore] // Iremos ignorar no momento da inclussão a obrigação de informar um livro
        public ICollection<LivroModel> Livros { get; set; }
    }
}
