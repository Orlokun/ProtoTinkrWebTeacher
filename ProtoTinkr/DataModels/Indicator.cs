namespace ProtoTinkr
{
    public class Indicator
    {
        //Default values TODO:Change DefaultSystem
        //Default values stored for when creating a new indicator in criteria
        private readonly int DefaultIndicatorScore = 1;
        private readonly string DefaultIndicatorTitle = "Dale un título a tu indicador o grado de logro";
        private readonly string DefaultIndicatorDescription = "Aún puedes agregar una descripción";
        public Indicator()
        {
            puntaje = DefaultIndicatorScore;
            title = DefaultIndicatorTitle;
            description = DefaultIndicatorDescription;
        }
        public float puntaje { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}