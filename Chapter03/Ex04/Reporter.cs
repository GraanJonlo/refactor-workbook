namespace Chapter03.Ex04
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Reporter
    {
        public static void Report(StringBuilder sb, List<Machine> machines, Robot robot)
        {
            sb.AppendLine("FACTORY REPORT");

            foreach (Machine machine in machines)
            {
                sb.Append("Machine " + machine.Name());

                if (machine.Bin() != null)
                    sb.Append(" bin=" + machine.Bin());

                sb.Append(Environment.NewLine);
            }

            sb.Append(Environment.NewLine);

            sb.Append("Robot");

            if (robot.Location() != null)
                sb.Append(" location=" + robot.Location().Name());

            if (robot.Bin() != null)
                sb.Append(" bin=" + robot.Bin());

            sb.Append(Environment.NewLine);

            sb.AppendLine("========");
        }
    }
}