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