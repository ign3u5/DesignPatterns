package patterns;

import patterns.Factory.Vehicle;

public class VehicleMock implements Vehicle {
  public String driveOutput;

  public String drive() {
    return driveOutput;
  }
}