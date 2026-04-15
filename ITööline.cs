using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public enum  TööTüüp
    {
        Palk,
        Toetus
    }
    public interface ITööline
    {
        TööTüüp ValjamakseTüüp { get; set; }
        public double ArvutaPalk();
    }
}
public enum Õppevorm
{
    Päevane,
    Kaugõpe,
    Ekstern,
    AkadeemilinePuhkus
}
