using System;

namespace BracketShow.CleanCode
{
    public class ReplaceConditionalWithPolymorphism
    {
        public double GetSpeed(Vehicule vehicule)
        {
            switch (vehicule.Type)
            {
                case VehiculeType.Car:
                    return GetBaseSpeed();
                case VehiculeType.Truck:
                    return GetBaseSpeed() * LoadFactor();
                case VehiculeType.Plane:
                    return GetBaseSpeed() - DragVector();
                default:
                    throw new NotImplementedException();
            }
        }

        private double GetBaseSpeed()
        {
            throw new NotImplementedException();
        }

        private double LoadFactor()
        {
            throw new NotImplementedException();
        }

        private double DragVector()
        {
            throw new NotImplementedException();
        }
    }

    public enum VehiculeType
    {
        Car,
        Truck,
        Plane
    }

    public class Vehicule
    {
        public VehiculeType Type { get; set; }
    }

    //public class Car : Vehicule
    //{
    //    protected override double GetSpeed()
    //    {
    //        return GetBaseSpeed();
    //    }
    //}
    //public class Truck : Vehicule
    //{
    //    protected override double GetSpeed()
    //    {
    //        return GetBaseSpeed() * LoadFactor();
    //    }

    //    private double LoadFactor()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public class Plane : Vehicule
    //{
    //    protected override double GetSpeed()
    //    {
    //        return GetBaseSpeed() - DragVector();
    //    }

    //    private double DragVector()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
