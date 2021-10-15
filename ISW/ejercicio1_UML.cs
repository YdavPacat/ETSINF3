public class Area{
    private string nombre;
    private ICollection <Collection> financiadaPor;
    public Area(string m, Colectivo c){
        this.nombre = m;
        this.financiadaPor = new List<Colectivo>();
        this.financiadaPor.Add(c);
    }
}
public abstract class Socio{
    private string nombre;
    private string estado;
    private string email;
    private ICollection<Rol> tiene;
    public Socio(string nombre, string estado, string email, Rol rol){}
}

public class Rol{
    private string nombre;
    private int salario;
    private string fecha_incio;
    private string fecha_fin;
    private Organizacion org;
    private Socio socio;
    public Rol(string nombre, string salario, string fecha_inicio, string fecha_fin, Organizacion org, Socio socio){}
}

public class Individual : Socio{
    public Individual(string nombre, string email, string estado, Rol rol) : base(nombre, estado, email, rol){}
}

public class Recurso{
    private string descripcion;
    private int precio;
    private ICollection<Organizacion> disponeDe;
    public Recurso(string descripcion, int precio, Organizacion disponeDe){
        this.descripcion = descripcion;
        this.precio = precio;
        this.disponeDe = new List<Organizacion>;
        this.disponeDe.Add(disponeDe);
    }
}

public class Organizacion {
    private stirng nombre;
    private stirng acronimo;
    private ICollection<Area> cubre;
    private ICollection<Resurso> disponeDe;
    private ICollection<Rol> roles;
    public Organizacion(string nombre, string acronimo, Rol rol)
}

public class Colectivo : Socio{
    private string razonSocial;
    private DateTime fechaAlta;
    public Colectivo(string razon, DateTime fecha, string nombre, string email, string estado, Rol rol):base(nombre,estado,email,rol){}
}