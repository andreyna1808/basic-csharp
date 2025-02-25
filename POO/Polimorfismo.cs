// Se baseia nas diferentes formas que um objeto pode ter
// Modificadores, Override, Abstract, etc

class Principal
{
   
   static void Main(){

      Gato gato = new Gato();
      Cao cao = new Cao();
      Panda panda = new Panda();

      // Panda[] vetor = {gato, cao, panda}; Isso daria erro pq nesse vetor ele só poderia guardar o valor de Panda
      Mamiferos[] vetor = {gato, cao, panda};

   }

}

class Mamiferos{}
class Gato:Mamiferos{}
class Cao:Mamiferos{}
class Panda:Mamiferos{}

// Abstract 
// É um metodo (função) vazia e sem implementação
// Serve como modelo para as demais

// Interface
// São classes que possuem o prototipo de um método
// Define regras e conteudos

public interface IAlgumaCoisa {
    void Metodo();
    Int Propriedade { get; set; }
    String Propriedade2 { get; }
    boolean Propriedade3 { get; set; }

}