namespace Lab2.AbstractFactory
{
    public class IProneLaptop : ILaptop { public string GetDetails() => "IProne Laptop"; }
    public class IProneSmartphone : ISmartphone { public string GetDetails() => "IProne Smartphone"; }

    public class KiaomiNetbook : INetbook { public string GetDetails() => "Kiaomi Netbook"; }
    public class KiaomiEBook : IEBook { public string GetDetails() => "Kiaomi EBook"; }

    public class BalaxyLaptop : ILaptop { public string GetDetails() => "Balaxy Laptop"; }
    public class BalaxySmartphone : ISmartphone { public string GetDetails() => "Balaxy Smartphone"; }
}
