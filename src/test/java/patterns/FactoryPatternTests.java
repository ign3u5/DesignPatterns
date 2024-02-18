package patterns;

import static org.junit.Assert.*;
import org.junit.Test;

import patterns.Factory.FactoryPattern;

public class FactoryPatternTests {
  @Test
  public void test() throws Exception {
    // Arrange
    String expectedDriveOutput = "Ship is driving";

    IOMock io = new IOMock();
    io.input = "10";

    VehicleFactoryMock vehicleFactory = new VehicleFactoryMock();
    VehicleMock vehicle = new VehicleMock();

    vehicleFactory.vehicle = vehicle;
    vehicle.driveOutput = expectedDriveOutput;

    FactoryPattern sut = new FactoryPattern(io, vehicleFactory);

    // Act
    sut.run();

    // Assert
    assertEquals(io.output, expectedDriveOutput);
  }
}