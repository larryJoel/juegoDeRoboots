class RobotSoldado: RobotBasico{
    int escudoMetal;
    public RobotSoldado(int x, int y, int id, string nombre, int energia, int escudo): base(x,y,id, nombre, energia){
        this.escudoMetal = escudo;
    }
    public void Atacar(RobotSoldado otro){
        otro.RecibirAtaque();
    }

    public new void RecibirAtaque(){
        if(escudoMetal > 0)
            escudoMetal --; //escudoMetal -1
        else base.RecibirAtaque();
    }

    public override void MostrarNombre()
    {
        Console.WriteLine("Soy un soldado y me llamo "+nombre);
    }

    public override string ToString()
    {
        return base.ToString()+" Escudo: "+escudoMetal;
    }
}