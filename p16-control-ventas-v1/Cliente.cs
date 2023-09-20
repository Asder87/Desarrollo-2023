public class Cliente{

    public string Name {get;set;}
    public string RFC {get;set;}
    public string Direccion{get;set;}
    public string Correo{get;set;}
    public double TCom {get;set;}


    public Cliente(string name, string rfc, string direccion, string correo,double tCom) => (Name,RFC,Direccion,Correo,TCom) = (name,rfc,direccion,correo,tCom);

    public override string ToString() => $"\nNombre: {Name}\nRFC: {RFC}\nDomicilio: {Direccion}\nCorreo: {Correo}\nTotal Acumulado: {TCom:f2}";
    
    public double sumaT(double x) => TCom += x;

}