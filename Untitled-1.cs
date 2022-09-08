//clase principal
  public class Libro{
    //metodo principal
   public static void Main(String[] args){
    //defino una istancia de libreria como bajo la misma estrella y inicializo como nueva
    libro bajolamismaestrella=new libro();
    //configura el autor 
    bajolamismaestrella.setautor("John Green");
    //configura las páginas 
    bajolamismaestrella.setnpages(301);
    //configura el ISBN 
    bajolamismaestrella.setISBN(978846);
    //defino una istancia de libreria como ciudades de papel y la inacializo como nueva
    libro ciudadesdepapel=new libro();
    //confiura el autor 
    ciudadesdepapel.setautor("John Green");
    //configura las páginas 
    ciudadesdepapel.setnpages(368);
    //configura el ISBN 
    ciudadesdepapel.setISBN(978841);
    //lee unos valores y los convierte
    bajolamismaestrella.tostring();
    //lee unos valores y los convierte
    ciudadesdepapel.tostring();

        if(bajolamismaestrella.getpage()>ciudadesdepapel.getpage()){
            Console.WriteLine("El primer libro tiene más páginas");
        }else{
            Console.WriteLine("El segundo libro tiene más páginas");
        }



    }
}