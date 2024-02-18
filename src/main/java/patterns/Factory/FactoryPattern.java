package patterns.Factory;

import java.io.IOException;

import patterns.Utils.IO;

public class FactoryPattern {
  private final IO io;

  public FactoryPattern(IO io) {
    this.io = io;
  }

  // What if we wanted to change the type of vehicle?
  // We're testing the Ship implementation every time as well.
  public void run() throws IOException {
    int lengthOfVehicle = Integer.valueOf(io.read());

    Vehicle vehicle = new Ship(lengthOfVehicle);

    io.write(vehicle.drive());
  }
}

// public class FactoryPattern {
//   private final IO io;
//   private Vehicle vehicle;
  
//   public FactoryPattern(IO io, Vehicle vehicle) {
//     this.io = io;
//     this.vehicle = vehicle;
//   }

//   // What if we wanted to change the vehicle's length?
//   public void run() {
//     io.write(vehicle.drive());
//   }
// }

// public class FactoryPattern {
//   private final IO io;
//   private VehicleFactory vehicleFactory;
  
//   public FactoryPattern(IO io, VehicleFactory vehicleFactory) {
//     this.io = io;
//     this.vehicleFactory = vehicleFactory;
//   }

//   public void run() throws IOException {
//     int lengthOfVehicle = Integer.valueOf(io.read());
//     Vehicle vehicle = vehicleFactory.createVehicle(lengthOfVehicle);
//     io.write(vehicle.drive());
//   }
// }