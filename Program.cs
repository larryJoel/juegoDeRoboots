class Program{
    public static void Main(){
        var mapa =  new List<Cosa>();
        var cosa1 = new Cosa(0,0,0,9,"Piedra");

        var RobotBasico1 =  new RobotBasico(1,2,10,"robotito",100);
        var RobotBasico2 =  new RobotBasico(3,3,11,"Bob",100);

        var soldado1 = new RobotSoldado(5,5,12,"Soldado1",100,100);
        var soldado2 = new RobotSoldado(7,7,12,"Soldado2",100,100);

        mapa.Add(cosa1);
        mapa.Add(RobotBasico1);
        mapa.Add(RobotBasico2);
        mapa.Add(soldado1);
        mapa.Add(soldado2);
        RobotBasico1.Atacar(RobotBasico2);
        soldado1.Atacar(RobotBasico2);
        soldado1.Atacar(soldado2);

        soldado1.DecirMiNombre();
        Cosa algo;
        algo = soldado1;
        algo.DecirMiNombre();
        RobotBasico rb;
        rb = soldado1;
        rb.DecirMiNombre();

        //Mostrar todos los que estan en el mapa
        foreach (var e in mapa)
        {
            Console.WriteLine(e);
        }
    }
}
