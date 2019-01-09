using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Virtual_fluid_bed_dryer
{
    public class Product
    {
        private int start_humidity;
        private double end_humidity;
        private double start_mass;
        private double final_mass;
        private double particle_diameter;

        public Product(int humidity, double mass_prod, double part_diam)
        {
            Start_humidity = humidity;
            Start_mass = mass_prod;
            End_humidity = humidity;
            Final_mass = mass_prod;
            Particle_diameter = part_diam;
        }

        public int Start_humidity
        {
            get { return start_humidity; }
            set { start_humidity = value; }
        }

        public double End_humidity
        {
            get { return end_humidity; }
            set { end_humidity = value; }
        }

        public double Start_mass
        {
            get { return start_mass; }
            set { start_mass = value; }
        }

        public double Final_mass
        {
            get { return final_mass; }
            set { final_mass = value; }
        }

        public double Particle_diameter
        {
            get { return particle_diameter; }
            set { particle_diameter = value; }
        }

        private double CtoK(double Temperature)
        {
            return Temperature + 273.15;
        }

        public double calculateHumidityModel1(InputAir air, Product prod)
        {

            double heat_capacity = 1.005;                   //TODO: rozne heat_capacity dla roznych temperatur i gazow
            double latent_heat_of_vaporization = 2257;      //TODO: different gases and vapour, make formula

            double result = (air.Mass_flow_rate * (heat_capacity * (CtoK(air.Temperature) - (CtoK(air.Wet_bulb_temperature))))) /
                    (prod.Start_mass * latent_heat_of_vaporization);

            return result;
        }


        public double calcualateHumidityModel2(double time, double delta)
        {
            bool done = false;
            double humidity_next = 0.0;
            double humidity_prev = 0.0;
            double b = 0.1;
            int r = 7;
            double hum_eq = 0.005;
            double hum_ind = 0.05;
            double result = 0.0;

            while (!done)
            {
                humidity_prev = (hum_eq + (hum_ind - hum_eq) * Math.Exp((-b * time) / (Math.Pow(r, 2))));

                b += 0.1;

                humidity_next = (hum_eq + (hum_ind - hum_eq) * Math.Exp((-b * time) / (Math.Pow(r, 2))));

                double cos = End_humidity;
                double tmp_delta = (End_humidity - (humidity_next * 100)) / 100;
                if (delta < tmp_delta)
                {
                    result = humidity_prev;
                    done = true;
                }
                
            }
                return result;
        }
    }
}