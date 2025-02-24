// A herança baseia-se no reaproveitamento do código passando propriedades e métodos entre classes

using System;

class Principal
{
    static void Main()
    {
        Felinos gatos = new Felinos();
        Console.WriteLine(gatos.vida); // 100
    }
}

class Animais
{
    public int vida = 100;
    public string especie;
    private int _peso = 0;
}

class Felinos
    : Animais { // Ela herda da classe de animais, ou seja possui vida e especie. Menos _peso pq é uma classe privada
}

// Obs.: Construtores não são herdados

class Classe1
{
    public Classe1(int valor)
    {
        Console.WriteLine("Construtor da classe 1");
    }
}

class Classe2 : Classe1
{
    static int valor = 10;

    // O construtor Classe2 chama o construtor Classe1
    // :base é usado para chamar o construtor da classe pai
    public Classe2()
        : base(valor)
    {
        Console.WriteLine("Construtor da classe 2");
    }
}

// Protected x sealed
// Ambos são privados, porém no proteced as classes derivadas podem acessar

// Get -> Leitura
// Set -> Escrita / alteração

// public int Algo { get; set; }