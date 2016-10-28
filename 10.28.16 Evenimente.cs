using System;
public delegate void MyEventHandlerDelegate(); // (a)

class MyEvent
{
    public event MyEventHandlerDelegate activare; // (c)
    public void Fire() // Crearea unei metode care genereaza evenimentul
    {
        activare();
    }
}

class EventDemo
{
    static void HandlerEv() // (d)
    {
        Console.WriteLine("Evenimentul s-a produs");
    }
    public static void Main()
    {
        MyEvent ev = new MyEvent(); // Crearea instantsei eveniment
        ev.activare += new MyEventHandlerDelegate(HandlerEv); // Adaugarea rutinei de tratere in lant
        ev.Fire(); // (e)
    }
}
