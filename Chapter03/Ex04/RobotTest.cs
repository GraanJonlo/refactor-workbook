namespace Chapter03.Ex04
{
    using Xunit;

    public class RobotTest
    {
        [Fact]
        public void TestRobot()
        {
            Machine sorter = new Machine("Sorter", "left");
            sorter.Put("chips");
            Machine oven = new Machine("Oven", "middle");
            Robot robot = new Robot();

            Assert.Equal("chips", sorter.Bin());
            Assert.Null(oven.Bin());
            Assert.Null(robot.Location());
            Assert.Null(robot.Bin());

            robot.MoveTo(sorter);
            robot.Pick();
            robot.MoveTo(oven);
            robot.Release();

            Assert.Null(robot.Bin());
            Assert.Equal(oven, robot.Location());
            Assert.Null(sorter.Bin());
            Assert.Equal("chips", oven.Bin());
        }
    }
}