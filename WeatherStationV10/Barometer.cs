namespace WeatherStationV10
{
    /// <summary>
    ///  Simple barometer, measuring pressure in hPa (hectopascal)
    /// </summary>
    public class Barometer
    {
        #region Instance fields
        private double _pressureInHPa;
        private string _stormy = "The weather is Stormy";
        private string _rainy = "The weather is Rainy";
        private string _changing = "The weather is Changing";
        private string _fair = "The weather is Fair";
        private string _veryDry = "The weather is Very dry";
        private string _nice = "All weather is nice!";
        #endregion

        #region Constructor
        public Barometer()
        {
            _pressureInHPa = 1000.0;
        }
        #endregion

        #region Properties
        public double Pressure
        {
            get { return _pressureInHPa; }
            set { _pressureInHPa = value; }
        }

        public string WeatherDescription
        {
            get 
            { 
                if (Pressure >= 1040)
                {
                    return _veryDry;
                }
                else if (Pressure >= 1020)
                {
                    return _fair;
                }
                else if (Pressure >= 1000)
                {
                    return _changing;
                }
                else if (Pressure >= 980)
                {
                    return _rainy;
                }
                else if (Pressure < 980)
                {
                    return _stormy;
                }
                else
                {
                    return "All weather is nice!";
                }
            }
        }
        #endregion
    }
}