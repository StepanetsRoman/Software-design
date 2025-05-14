namespace Lab2.AbstractFactory
{
    public interface ITechFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }

    public class IProneFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new IProneLaptop();
        public INetbook CreateNetbook() => null!;
        public IEBook CreateEBook() => null!;
        public ISmartphone CreateSmartphone() => new IProneSmartphone();
    }

    public class KiaomiFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => null!;
        public INetbook CreateNetbook() => new KiaomiNetbook();
        public IEBook CreateEBook() => new KiaomiEBook();
        public ISmartphone CreateSmartphone() => null!;
    }

    public class BalaxyFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new BalaxyLaptop();
        public INetbook CreateNetbook() => null!;
        public IEBook CreateEBook() => null!;
        public ISmartphone CreateSmartphone() => new BalaxySmartphone();
    }
}
