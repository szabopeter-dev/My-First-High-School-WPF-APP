using System;
using System.Collections.Generic;


public class kgkezisulyzo
{
    //fieldek
    private int sulynagysag;
    private string sulytipus;

    //konstruktor 
    public kgkezisulyzo(int sulynagysag, string sulytipus)
    {
        this.sulynagysag = sulynagysag;
        this.sulytipus = sulytipus;
    }
    //Getter
    public int getNagysag
    {
        set
        {

        }

        get
        {
            return sulynagysag;
        }
    }
    public string getTipus
    {
        set
        {

        }
        get
        {
            return sulytipus;
        }
    }
}



