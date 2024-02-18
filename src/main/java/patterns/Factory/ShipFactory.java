package patterns.Factory;
public class ShipFactory implements VehicleFactory {
  public Ship createVehicle(int lengthOfShip) {
    return new Ship(lengthOfShip);
  }
}
