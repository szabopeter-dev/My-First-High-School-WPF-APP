using System;


public class labgepek
{

    private int kgkapacitas;
    private string geptipus;


    public labgepek(int kgkapacitas, string geptipus)
    {
        this.kgkapacitas = kgkapacitas;
        this.geptipus = geptipus;
    }

    public string getTipus
    {
        set
        {

        }

        get
        {
            return geptipus;
        }
    }
    public int getKapacitas
    {
        set
        {

        }
        get
        {
            return kgkapacitas;
        }
    }
}



