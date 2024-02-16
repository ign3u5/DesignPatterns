import Factory.VehicleFactory;

public class Program {
  public static void main(String...args) {
  }

  public void driveTheVehicle(VehicleFactory vehicleFactory) {
    var vehicle = vehicleFactory.createVehicle(10);

    System.out.println(vehicle.drive());
  }
}