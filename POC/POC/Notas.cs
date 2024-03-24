namespace POC
{
    public class Notas
    {
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        public int CalcularMediaAnual(Notas notas)
        {
            int mediaAnual = (notas.Nota1 + notas.Nota2 + notas.Nota3 + notas.Nota4) / 4;
            return mediaAnual;
        }

        public bool AplicarRegraMediaAnual(int mediaAnual)
        {
            bool retornoCalcularMediaAnual = false;
            if (mediaAnual >= 7)
            {
                retornoCalcularMediaAnual = true;
            }
            return retornoCalcularMediaAnual;
        }
    }
}