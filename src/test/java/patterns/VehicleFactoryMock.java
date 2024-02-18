package patterns;

import patterns.Factory.Vehicle;
import patterns.Factory.VehicleFactory;

public class VehicleFactoryMock implements VehicleFactory {
  public Vehicle vehicle;
  public int length;
  
  public Vehicle createVehicle(int length) {
    this.length = length;
    return vehicle;
  }
}