namespace WebApi8_Video.Models
{
    public class ResponseModel<T> // Tipo genérico
    {
        public T? Dados { get; set; } // Interrogação significa que o dado pode ser nulo.
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;

    }
}
