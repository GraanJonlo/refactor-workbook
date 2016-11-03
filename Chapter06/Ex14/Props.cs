namespace Chapter06.Ex14
{
    public class Props
    {
        private int checkInterval;
        private int departureOffset;
        private int monitorTime;

        public void getTimes(Properties props)
        {
            string valueString;
            int value;

            valueString = props.GetProperty("interval");
            if (valueString == null) throw new MissingPropertiesException("monitor interval");
            value = int.Parse(valueString);

            if (value <= 0) throw new MissingPropertiesException("monitor interval > 0");
            checkInterval = value;

            valueString = props.GetProperty("duration");
            if (valueString == null) throw new MissingPropertiesException("duration");
            value = int.Parse(valueString);
            if (value <= 0) throw new MissingPropertiesException("duration > 0");
            if (value%checkInterval != 0) throw new MissingPropertiesException("duration % checkInterval");
            monitorTime = value;

            valueString = props.GetProperty("departure");
            if (valueString == null) throw new MissingPropertiesException("departure offset");
            value = int.Parse(valueString);
            if (value <= 0) throw new MissingPropertiesException("departure > 0");
            if (value%checkInterval != 0) throw new MissingPropertiesException("departure % checkInterval");
            departureOffset = value;
        }

        // ....
    }
}