public class Venta {
    public string Articulo {get;set;}
    public int NoA {get;set;}
    public double Precio {get;set;}

    public double subtotal = 0;

    public Venta(string articulo,int noA,double precio) => (Articulo,NoA,Precio) = (articulo,noA,precio);


    public double subT(int x,double y){
        subtotal = x*y;
        return subtotal;
    }

}

