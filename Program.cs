public class libro{
    private string titulo="", autor="";
    private int ISBN, npages;
    
    
    public void gettitulo(){
        Console.WriteLine(this.titulo);
    }
    public void settitulo(string title){
        this.titulo=title;
    }
     public void getautor(){
        Console.WriteLine(this.autor);
     }
    public string setautor(string autor){
        return this.autor=autor;
    }
    public void getISBN(){
        Console.WriteLine(this.ISBN);
    }
    public int setISBN(int ncode){
        return this.ISBN=ncode;
    }
    public int getpage(){
        return this.npages;
    }
    public int setnpages(int npagi){
        return this.npages=npagi;
    }
    public void tostring(){ Console.WriteLine("El libro "+this.titulo+" con ISBN "+this.ISBN+" creado por el autor "+this.autor+" tiene "+this.npages+" paginas.");
    }
}