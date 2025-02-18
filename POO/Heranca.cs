// A herança baseia-se no reaproveitamento do código passando propriedades e métodos entre classes

using System;

class Principal {
    static void Main() {
        Felinos gatos = new Felinos();
        Console.WriteLine(gatos.vida); // 100

    }
}

class Animais {
    public int vida = 100;
    public string especie;
    private int _peso = 0;
}

class Felinos: Animais { // Ela herda da classe de animais, ou seja possui vida e especie. Menos _peso pq é uma classe privada

}

// Obs.: Construtores não são herdados