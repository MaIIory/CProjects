using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Virtual_fluid_bed_dryer
{


    public class InputAir
    {

        private double temperature; //temperatura w stopniach celciusza
        private double heating_rate; //predkosc podgrzewania
        private string gas_name; //nazwa gazu
        private double volume_flow_rate; //przepustowosc (m3/h)
        private double humidity_ratio; //wskaznik wilgotnosci
        private double pressure; //cisnienie
        private double specific_gas_const; //stala gazowa
        private double density; //gestosc
        private double mass_flow_rate; //natezenie przeplywu
        private double relative_humidity; //Relative humidity
        private double wet_bulb_temp;

        private double saturation_mixing_ratio;

        public InputAir(double temp, string gas_name, double volume_flow_rate, double humidity_ratio, double pressure)
        {
            Temperature = temp;
            Gas_name = gas_name;
            Volume_flow_rate = volume_flow_rate;
            Humidity_ratio = humidity_ratio;
            Pressure = pressure;
            specific_gas_const = 287.058;   //TODO: specific gas const for different gases
            density = calculateDensity(Pressure, specific_gas_const, Temperature + 273.15);
            mass_flow_rate = (volume_flow_rate * density) / 3600;
            saturation_mixing_ratio = calculateSMR(Pressure, Temperature);              //calculating saturation mixing ratio
            relative_humidity = calculateRH(Humidity_ratio, saturation_mixing_ratio);   //calculating relative humidity
            wet_bulb_temp = calculateWB(Temperature, Pressure, relative_humidity);      //calculating wet bulb temperature
        }

        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public double Heating_rate
        {
            get { return heating_rate; }
            set { heating_rate = value; }
        }

        public string Gas_name
        {
            get { return gas_name; }
            set { gas_name = value; }
        }

        public double Volume_flow_rate
        {
            get { return volume_flow_rate; }
            set { volume_flow_rate = value; }
        }

        public double Humidity_ratio
        {
            get { return humidity_ratio; }
            set { humidity_ratio = value; }
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public double Specific_gas_const
        {
            get { return specific_gas_const; }
        }

        public double Saturation_mixing_ratio
        {
            get { return saturation_mixing_ratio; }
            set { saturation_mixing_ratio = value; }

        }

        public double Relative_humidity
        {
            get { return relative_humidity; }
            set { relative_humidity = value; }
        }

        public double Density
        {
            get { return density; }
            set { density = value; }
        }

        public double Mass_flow_rate
        {
            get { return mass_flow_rate; }
            set { mass_flow_rate = value; }
        }

        public double Wet_bulb_temperature
        {
            get { return wet_bulb_temp; }
            set { wet_bulb_temp = value; }
        }

        public double heatTemperature()
        {
            return 0;
        }

        public double calculateMassFlowRate()
        {
            return (Volume_flow_rate * Density) / 3600;
        }

        public double calculateDensity(double pressure, double specific_gas_const, double temperature)
        {
            double result = (pressure / (specific_gas_const * temperature)) * 100;
            return result;
        }

        public double calculateSMR(double pressure, double temperature)
        {
            double tmp_result = System.Math.Pow(10,((7.5 * temperature) / (temperature + 237.7)));
            tmp_result = tmp_result * 6.11;
            return (621.97 * ((tmp_result)/(pressure - tmp_result))) / 1000;
        }

        public double calculateRH(double humidity_ratio, double saturation_mixing_ratio)
        {
            double tmp_result = (humidity_ratio/ (saturation_mixing_ratio));

            return tmp_result;
        }

        public double calculateWB(double Temperature, double Pressure, double rh)
        {
            double Es = 6.112 * Math.Exp(17.67 * Temperature / (Temperature + 243.5));
            double E2 = Es * ((rh * 100) / 100.0);
            double Twguess = 0.0;
            double incr = 0.1;
            double previoussign = 1.0;
            double Edifference = 1.0;

            while(Math.Abs(Edifference) > 0.05)
            {
                double Ewguess = 6.112 * Math.Exp((17.67 * Twguess) / (Twguess + 243.5));
                double Eguess = Ewguess - Pressure * (Temperature - Twguess) * 0.00066 * (1 + (0.00115 * Twguess));
                Edifference = E2 - Eguess;

                if(Edifference == 0) break;
                else
                {
                if(Edifference < 0)
                    {
                        if (previoussign != -1)
                        {
                            previoussign = -1;
                            incr = incr / 10;
                        }
                    }
                else
                    {
                        if(previoussign != 1)
                        {
                            previoussign = 1;
                            incr = incr/10;
                        }   
                    }
                }
                Twguess = Twguess + incr * previoussign;       
            }
            return Twguess;

        }
    }
}