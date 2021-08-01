namespace DigitalInnovationOneExemplo4.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //Faca algum calculo...
        }

        private void CalcularDistancia2()
        {
            //Faca algum calculo...
        }

        public virtual void CalcularDistancia3()
        {
            //Faca algum calculo...
        }
    }
}