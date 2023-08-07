using System;
namespace CreatingInterface
{

    class Program
    {
        static void Main(string[] args)
        {
            Polo polo = new Polo();
            Amarok amarok = new Amarok();
            GTI gTI = new GTI();
            polo.Badge();
            amarok.Paint();
            amarok.Badge();
            gTI.Polish();
            gTI.inspection();


        }
    }
    public class Polo:IControls
    {

        public void Badge() 
        {

        }

        public void Infortainment()
        {
            throw new NotImplementedException();
        }

        public void inspection()
        {
            throw new NotImplementedException();
        }

        public void Wheels()
        {
            throw new NotImplementedException();
        }
    }
    public class Amarok:IControls
    {
        public void Badge()
        {
            throw new NotImplementedException();
        }

        public void Infortainment()
        {
            throw new NotImplementedException();
        }

        public void inspection()
        {
            throw new NotImplementedException();
        }

        public void Paint()
        {

        }
        public void Wheels()
        {

        }
    }
    public class GTI:IControls
    {

        public void Polish()
        {

        }
        public void Inspection()
        {

        }

        public void Badge()
        {
            throw new NotImplementedException();
        }

        public void Infortainment()
        {
            throw new NotImplementedException();
        }

        public void Wheels()
        {
            throw new NotImplementedException();
        }

        public void inspection()
        {
            throw new NotImplementedException();
        }
    }
    interface IControls
    {
        void Badge();
        void Infortainment();
        void Wheels();
        void inspection();

    }
    
}