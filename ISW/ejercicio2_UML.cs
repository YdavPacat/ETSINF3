public class ClassA{
    private string a1;
    private int a2;
    private ClassE asociacionAE;
    private ICollection<ClassC> claseAC; 
    public ClassA(string a1, int a2, ClassC claseAC){}
}
public class ClassB{
   private string b1;
   private ICollections<ClassC> tiene; 
   public ClassB(string b1); 
}
public class ClassC{
    private int c1;
    private ClassB b;
    private ClassA a;
    private int h1;
    private ClassD asociacionCD;
    public ClassC(int c1, ClassB b, ClassA a, int h1, ClassD asociacionCD){}
}
public class ClassD{
    private string d1;
    private ICollection<ClassC> asociacionCD;
    private ICollection<ClassG> claseG;
    public ClassD(string d1, ClassG claseG, ClassC asociacionCD){}
}
public class ClassE : ClassD{
    private int e1;
    private ClassA asociacionAE;
    public ClassE(int e1, ClassA asociacionAE, string d1, ClassC asociacionCD, ClassG claseG):base(d1, asociacionCD, claseG){}
}
 
public class ClassF: ClassD{
    private boolean f1;
    public ClassF(boolean f1, string d1, ClassC asociacionCD, ClassG claseG) : base (d1, asociacionCD, claseG){}
}

public class ClassG{
    private string g1;
    public ClassG(string g1){}
}