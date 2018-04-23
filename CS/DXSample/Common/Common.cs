namespace DXSample.Common {
    public enum ModuleType { 
        Customers, 
        Sales, 
        Products 
    }

    public static class Regions {
        public static string Main { get { return "MainRegion"; } }
        public static string Navigation { get { return "NavigationRegion"; } }
    }
}
