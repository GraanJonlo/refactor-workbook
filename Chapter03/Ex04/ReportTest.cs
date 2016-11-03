namespace Chapter03.Ex04
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;

    public class ReportTest
    {
        [Fact]
        public void TestReport()
        {
            var line = new List<Machine>();
            line.Add(new Machine("mixer", "left"));

            Machine extruder = new Machine("extruder", "center");
            extruder.Put("paste");
            line.Add(extruder);

            Machine oven = new Machine("oven", "right");
            oven.Put("chips");
            line.Add(oven);

            Robot robot = new Robot();
            robot.MoveTo(extruder);
            robot.Pick();

            var sb = new StringBuilder();
            Reporter.Report(sb, line, robot);

            string expected =
                "FACTORY REPORT" + Environment.NewLine +
                "Machine mixer" + Environment.NewLine + "Machine extruder" + Environment.NewLine +
                "Machine oven bin=chips" + Environment.NewLine + Environment.NewLine +
                "Robot location=extruder bin=paste" + Environment.NewLine +
                "========" + Environment.NewLine;

            string actual = sb.ToString();

            Assert.Equal(expected, actual);
        }
    }
}