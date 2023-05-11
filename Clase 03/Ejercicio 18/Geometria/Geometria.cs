namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public int GetX() 
        {
            return x;
        }

        public int GetY() 
        {
            return y;
        }
    }

    public class Rectangulo 
    {
        private float area = -1;
        private float perimetro = -1;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        
        public Rectangulo(Punto verticeUno, Punto verticeTres) 
        {
            vertice1 = verticeUno;
            vertice2 = new Punto(verticeTres.GetX(), verticeUno.GetY());
            vertice3 = verticeTres;
            vertice4 = new Punto(verticeUno.GetX(), verticeTres.GetY());
        }

        public float GetArea() 
        {
            if (this.area == -1) 
            {
                float largo = Math.Abs(vertice1.GetX() - vertice2.GetX());
                float altura = Math.Abs(vertice1.GetY() - vertice4.GetY());
                this.area = largo * altura;
                //Console.WriteLine("Se calculo el area");
            }
            return this.area;
        }

        public float GetPerimetro() 
        {
            if (this.perimetro == -1) 
            {
                float largo = Math.Abs(vertice1.GetX() - vertice2.GetX());
                float altura = Math.Abs(vertice1.GetY() - vertice4.GetY());
                this.perimetro = (largo + altura) * 2;
                //Console.WriteLine("Se calculo el perimetro");
            }
            return this.perimetro;
        }

        public void MostrarDatos() 
        {
            Console.WriteLine($"Coordenadas vertice uno: ({this.vertice1.GetX()},{this.vertice1.GetY()})");
            Console.WriteLine($"Coordenadas vertice dos: ({this.vertice2.GetX()},{this.vertice2.GetY()})");
            Console.WriteLine($"Coordenadas vertice tres: ({this.vertice3.GetX()},{this.vertice3.GetY()})");
            Console.WriteLine($"Coordenadas vertice cuatro: ({this.vertice4.GetX()},{this.vertice4.GetY()})");
            if (this.GetArea() != 0)
            {
                Console.WriteLine($"Area: {this.GetArea()}");
                Console.WriteLine($"Perimetro: {this.GetPerimetro()}");
            }
            else 
            {
                Console.WriteLine("Error! El largo o la altura del rectangulo es 0");
            }
            

        }

    }
}