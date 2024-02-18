package patterns.Factory;

public class Ship implements Vehicle {
  private int lengthOfShip;

  public Ship(int lengthOfShip) {
    this.lengthOfShip = lengthOfShip;
  }

  public String drive() {
    return "Ship moves " + lengthOfShip + " meters!";
  }
}