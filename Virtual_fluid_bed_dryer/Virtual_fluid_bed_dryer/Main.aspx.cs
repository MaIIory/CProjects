using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Reflection;
using System.Web.UI.DataVisualization.Charting;

namespace Virtual_fluid_bed_dryer
{
    public partial class Main : System.Web.UI.Page
    {
        private InputAir in_air;
        private Product prod;
        Label lblLogin;
        public event System.EventHandler Click;

        protected void Page_Load(object sender, EventArgs e)
        {

            

            lblLogin = (Label)Master.FindControl("lblLogin");
            lblLogin.Text = Server.UrlDecode(Request.QueryString["Data"]).ToString();
 
            //checking if it is restore result session
            if (Request.QueryString.Count == 2)
            {
                try
                {
                    int ResId = Int16.Parse(Server.UrlDecode(Request.QueryString["Exp"]));
                    ExperimentResult exp_res = DataEditor.GetExpById(ResId);

                    chkGoal1.Checked = false;
                    chkGoal2.Checked = false;
                    txtTrackTime.Text = "";
                    txtHumLevel.Text = "";
                    plhGoal1.Visible = false;
                    plhGoal2.Visible = false;

                    txtProdHumidity.Text = exp_res.Start_humidity.ToString();
                    txtTrackHumidity.Text = exp_res.Start_humidity.ToString();

                    txtProdMass.Text = exp_res.Mass.ToString();
                    txtProdParticle.Text = exp_res.Particle_diameter.ToString();
                    txtVolFlowRate.Text = exp_res.Volume_flow_rate.ToString();
                    txtAirHumRatio.Text = exp_res.Humidity_ratio.ToString();
                    txtDryTemp.Text = exp_res.Drying_temperature.ToString();
                    txtTemperature.Text = exp_res.Start_gas_temperature.ToString();
                    txtPressure.Text = exp_res.Pressure.ToString();
                    txtHeatingSpeed.Text = exp_res.Machine_heating_rate.ToString();

                    //identify the main goal
                    if (exp_res.Desired_humidity_level == 0)
                    {
                        //The main goal = specified time
                        plhGoal2.Visible = true;
                        chkGoal2.Checked = true;
                        txtTrackTime.Text = exp_res.Time_of_drying.ToString();
                    }
                    else
                    {
                        //the main goal = specified humidity
                        plhGoal1.Visible = true;
                        chkGoal1.Checked = true;
                        txtHumLevel.Text = exp_res.Desired_humidity_level.ToString();
                    }

                    //remote main function call
                    if (this.Click != null)
                        this.Click(this, new EventArgs());
                    btnStartCalc_Click(this, e);


                    //clear query string
                    PropertyInfo isreadonly =
                            typeof(System.Collections.Specialized.NameValueCollection).GetProperty(
                            "IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                    // make collection editable
                    isreadonly.SetValue(this.Request.QueryString, false, null);
                    // remove
                    this.Request.QueryString.Remove("Exp");
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('" + ex.Message.ToString() + "');", true);
                }
            }
        }

        public void btnStartCalc_Click(object sender, EventArgs e)
        {
            //clear mask leavings
            txtProdMass.Text = txtProdMass.Text.Trim('_');
            txtProdParticle.Text = txtProdParticle.Text.Trim('_');
            txtVolFlowRate.Text = txtVolFlowRate.Text.Trim('_');
            txtAirHumRatio.Text = txtAirHumRatio.Text.Trim('_');
            txtDryTemp.Text = txtDryTemp.Text.Trim('_');
            txtTemperature.Text = txtTemperature.Text.Trim('_');
            txtPressure.Text = txtPressure.Text.Trim('_');
            txtHeatingSpeed.Text = txtHeatingSpeed.Text.Trim('_');

            //chart inicialization
            chartResult1.Titles.Clear();
            chartResult1.Series.Clear();

            //getting data for creating new air instance
            string gas_name = ddlGasName.SelectedValue.ToString();
            //double temperature = double.Parse(txtTemperature.Text.Trim());

            try
            {

                double temperature = 0;
                if (ddlStartGasTemp.SelectedValue == "0")
                    temperature = double.Parse(txtTemperature.Text.Trim());
                else if (ddlStartGasTemp.SelectedValue == "1")
                    temperature = FtoC(double.Parse(txtTemperature.Text.Trim()));
                else if (ddlStartGasTemp.SelectedValue == "2")
                    temperature = KtoC(double.Parse(txtTemperature.Text.Trim()));

                double volume_flow_rate = double.Parse(txtVolFlowRate.Text.Trim());
                double humidity_ratio = double.Parse(txtAirHumRatio.Text.Trim()) / 1000;
                double pressure = double.Parse(txtPressure.Text.Trim());
                double start_temp = temperature;

                //creating new air instance
                in_air = new InputAir(temperature, gas_name, volume_flow_rate, humidity_ratio, pressure);
                //creating new product instance
                this.prod = new Product(int.Parse(txtTrackHumidity.Text.Trim()), double.Parse(txtProdMass.Text.Trim()), double.Parse(txtProdParticle.Text.Trim()));

                double drying_temperature = 0;
                if (ddlTempOfDry.SelectedValue == "0")
                    drying_temperature = double.Parse(txtDryTemp.Text.Trim());
                else if (ddlTempOfDry.SelectedValue == "1")
                    drying_temperature = FtoC(double.Parse(txtDryTemp.Text.Trim()));
                else if (ddlTempOfDry.SelectedValue == "2")
                    drying_temperature = KtoC(double.Parse(txtDryTemp.Text.Trim()));

                if (temperature >= drying_temperature)
                {
                    Exception ex = new Exception("Drying temperature should be greater than input gas temperature.");
                    throw ex;
                }

                if (temperature > 200)
                {
                    Exception ex = new Exception("Input gas temperature should be less or equal to 200 °C.");
                    throw ex;
                }

                if (drying_temperature > 200)
                {
                    Exception ex2 = new Exception("Drying temperature should be less or equal to 200 °C.");
                    throw ex2;
                }

                //Showing result elements
                plhResult1.Visible = true;
                plhResult2.Visible = true;
                plhResult3.Visible = true;
                plhResult4.Visible = true;

                //fetching info to gas result div
                lblRsGasType.Text = in_air.Gas_name.ToString();
                lblRsInAirTemp.Text = in_air.Temperature.ToString();
                lblRsVolFlowRate.Text = in_air.Volume_flow_rate.ToString();
                lblRsHumRatio.Text = in_air.Humidity_ratio.ToString();
                lblRsPressure.Text = in_air.Pressure.ToString();
                lblRsGasConst.Text = in_air.Specific_gas_const.ToString();
                lblRsDensity.Text = in_air.Density.ToString();
                lblRsMassFlowRate.Text = in_air.Mass_flow_rate.ToString();
                lblRsSMR.Text = in_air.Saturation_mixing_ratio.ToString();
                lblRsRH.Text = in_air.Relative_humidity.ToString();
                lblRsWBT.Text = in_air.Wet_bulb_temperature.ToString();

                //fetching info to product and drying settings div
                lblRs2StartHumidity.Text = prod.Start_humidity.ToString();
                lblRs2StartMass.Text = prod.Start_mass.ToString();
                lblRs2ParticleDiameter.Text = prod.Particle_diameter.ToString();
                lblRs2HeatinRate.Text = txtHeatingSpeed.Text.ToString();



                

                lblRs2DryingTemperature.Text = txtDryTemp.Text.ToString(); //TODO może być w innej jednostce, lepiej żeby było w Celsjuszach

                if (chkGoal1.Checked)
                {
                    lblRs2DesHumLevel.Text = int.Parse(txtHumLevel.Text.Trim()).ToString();
                    lblRs2DesTimeOfDry.Text = "n/a";
                }
                else if (chkGoal2.Checked)
                {
                    lblRs2DesTimeOfDry.Text = txtTrackTime.Text.ToString();
                    lblRs2DesHumLevel.Text = "n/a";
                }

                //initialization of main parameters
                double heating_rate = double.Parse(txtHeatingSpeed.Text.Trim()) / 100;


                int dry_time = 0;
                if (chkGoal2.Checked) dry_time = int.Parse(txtTrackTime.Text.Trim()) * 60;
                int desired_hum = 0;
                if (chkGoal1.Checked) desired_hum = int.Parse(txtHumLevel.Text.Trim());

                int sec_counter = 0;
                double delta_hum = 0;
                double hum_before = 0;

                //Result data containers initialization
                double[] wet_bulb_result;
                float[] humidity_results;
                double[] temperature_results;
                double[] mass_results;

                if (chkGoal2.Checked)
                {
                    humidity_results = new float[dry_time];
                    temperature_results = new double[dry_time];
                    wet_bulb_result = new double[dry_time];
                    mass_results = new double[dry_time];
                }
                else
                {
                    humidity_results = new float[600 * 60];
                    temperature_results = new double[600 * 60];
                    wet_bulb_result = new double[600 * 60];
                    mass_results = new double[600 * 60];
                }


                /*************************************SIMULATION START***********************************************/
                double model2_counter = 0;

                //find goal

                bool goal_achieved = false;


                while (!goal_achieved)
                //while (dry_time != 0)
                {

                    //check if temperature achieved constant value
                    if (in_air.Temperature != drying_temperature)
                    {
                        if (in_air.Temperature < drying_temperature)
                        {
                            in_air.Temperature = in_air.Temperature + (in_air.Temperature * (heating_rate / 60.0)); //dry air a little
                            if (in_air.Temperature > drying_temperature) in_air.Temperature = drying_temperature;   //this is in case "overheating"
                        }

                        in_air.Density = in_air.calculateDensity(in_air.Pressure, in_air.Specific_gas_const, CtoK(in_air.Temperature));
                        in_air.Mass_flow_rate = in_air.calculateMassFlowRate();
                        in_air.Saturation_mixing_ratio = in_air.calculateSMR(in_air.Pressure, in_air.Temperature);
                        in_air.Relative_humidity = in_air.calculateRH(in_air.Humidity_ratio, in_air.Saturation_mixing_ratio);
                        in_air.Wet_bulb_temperature = in_air.calculateWB(in_air.Temperature, in_air.Pressure, in_air.Relative_humidity);
                        if (in_air.Wet_bulb_temperature < start_temp) in_air.Wet_bulb_temperature = start_temp;
                    }

                    wet_bulb_result[sec_counter] = in_air.Wet_bulb_temperature;
                    temperature_results[sec_counter] = in_air.Temperature;

                    //Calculate humidity
                    hum_before = prod.End_humidity;
                    //According to Model I
                    if (prod.End_humidity > 5)
                    {

                        double tmp_hum = prod.End_humidity - (prod.calculateHumidityModel1(in_air, prod) * 100);
                        if (tmp_hum < 5)
                        {
                            model2_counter += 1;
                            this.prod.End_humidity = prod.calcualateHumidityModel2(model2_counter / 60, delta_hum) * 100;
                        }
                        else
                        {
                            this.prod.End_humidity = tmp_hum;
                        }
                    }
                    //According to Model II
                    else
                    {
                        model2_counter += 1;
                        this.prod.End_humidity = prod.calcualateHumidityModel2(model2_counter / 60, delta_hum) * 100;
                    }

                    humidity_results[sec_counter] = float.Parse(prod.End_humidity.ToString());
                    //calculating product mass
                    delta_hum = (hum_before - prod.End_humidity) / 100;
                    prod.Final_mass = prod.Final_mass - (prod.Final_mass * delta_hum);
                    mass_results[sec_counter] = prod.Final_mass;

                    sec_counter += 1;
                    dry_time -= 1;
                    if (chkGoal1.Checked && (prod.End_humidity <= desired_hum)) goal_achieved = true;
                    else if (chkGoal2.Checked && (dry_time <= 0)) goal_achieved = true;
                    else if (sec_counter == 600 * 60) break;

                }

                /*************************************SIMULATION END***********************************************/

                //fetching info to final experiment result div
                lblRs3TotalTime.Text = sec_counter.ToString();  //TODO min/sec dwie labelki
                lblRs3EndHumidity.Text = Math.Round(prod.End_humidity, 4).ToString();
                lblRs3EndMass.Text = Math.Round(prod.Final_mass, 4).ToString();
                lblRs3HumAchieved.Text = "n/a";                 //calkowicie do zrobienia
                if (chkGoal1.Checked && !goal_achieved) lblRs3HumAchieved.Text = "No";
                else if (chkGoal1.Checked && goal_achieved) lblRs3HumAchieved.Text = "Yes";

                /************************* CHART1 - HUMIDITY RESULT *************************************/

                //Settings properties
                chartResult1.Width = 1000; //TODO: Automatyczne wymiary - maksymalne jakie sie da
                chartResult1.Height = 800;
                string series_name = "Product Humidity";                            //nazwa serii
                chartResult1.Legends.Add(series_name).Title = "Legend";             //tytul Legendy
                chartResult1.Series.Add(series_name);                               //dodanie serii do wykresu
                chartResult1.Series[series_name].ChartType = SeriesChartType.Line;  //typ wykresu
                chartResult1.Series[series_name].BorderWidth = 3;                   //drubosc wykresu
                Title title = new Title("Humidity of drying product");              //nowa instancja tytulu
                chartResult1.Titles.Add(title);                                     //dodanie tytulu
                chartResult1.ChartAreas["ChartArea1"].AxisX.Title = "Time [sec]";         //labelka osi x
                chartResult1.ChartAreas["ChartArea1"].AxisY.Title = "Humidity [%]";     //labelka osi y
                chartResult1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = true;
                chartResult1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = true;
                chartResult1.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = false;

                chartResult1.Series[series_name].ToolTip = "X value \t= #VALX\nY value \t= #VALY";
                //chartResult1.ChartAreas["ChartArea1"].AxisX.Interval = 0.1;        

                //*************************CHART2*************************************

                chartResult2.Width = 1000; //TODO: Automatyczne wymiary - maksymalne jakie sie da
                chartResult2.Height = 800;
                string temp_series = "Gas temperature";
                string wet_bulb_series = "Wet bulb temperature";
                chartResult2.Legends.Clear();
                chartResult2.Legends.Add(temp_series).Title = "Legend";
                chartResult2.Legends.Add(wet_bulb_series).Title = "Legend";
                chartResult2.Series.Add(temp_series);
                chartResult2.Series.Add(wet_bulb_series);
                chartResult2.Series[temp_series].ChartType = SeriesChartType.Line;
                chartResult2.Series[wet_bulb_series].ChartType = SeriesChartType.Line;
                chartResult2.Series[temp_series].Color = System.Drawing.ColorTranslator.FromHtml("#FFBE0D");
                chartResult2.Series[wet_bulb_series].Color = System.Drawing.ColorTranslator.FromHtml("#3366FF");
                chartResult2.Series[temp_series].BorderWidth = 3;
                chartResult2.Series[wet_bulb_series].BorderWidth = 3;
                Title title2 = new Title("Temperatures of drying process");
                chartResult2.Titles.Add(title2);
                chartResult2.ChartAreas["ChartArea2"].AxisX.Title = "Time [sec]";
                chartResult2.ChartAreas["ChartArea2"].AxisY.Title = "Temperature [C]";
                chartResult2.ChartAreas["ChartArea2"].AxisX.MinorGrid.Enabled = true;
                chartResult2.ChartAreas["ChartArea2"].AxisY.MinorGrid.Enabled = true;
                chartResult2.ChartAreas["ChartArea2"].AxisX.IsMarginVisible = false;

                //chartResult2.Series[temp_series].ToolTip = "X value \t= #VALX\nY value \t= #VALY\n";
                //chartResult2.Series[wet_bulb_series].ToolTip = "X value \t= #VALX\nY value \t= #VALY\n"; 
                //chartResult1.ChartAreas["ChartArea1"].AxisX.Interval = 0.1;        

                //*************************CHART3*************************************

                chartResult3.Width = 1000; //TODO: Automatyczne wymiary - maksymalne jakie sie da
                chartResult3.Height = 800;
                string mass_series = "Product Mass";
                chartResult3.Legends.Add(mass_series).Title = "Legend";
                chartResult3.Series.Add(mass_series);
                chartResult3.Series[mass_series].ChartType = SeriesChartType.Line;
                chartResult3.Series[mass_series].BorderWidth = 3;
                Title title3 = new Title("Mass of drying product");
                chartResult3.Titles.Add(title3);
                chartResult3.ChartAreas["ChartArea2"].AxisX.Title = "Time [sec]";
                chartResult3.ChartAreas["ChartArea2"].AxisY.Title = "Mass [kg]";
                chartResult3.ChartAreas["ChartArea2"].AxisX.MinorGrid.Enabled = true;
                chartResult3.ChartAreas["ChartArea2"].AxisY.MinorGrid.Enabled = true;
                chartResult3.ChartAreas["ChartArea2"].AxisX.IsMarginVisible = false;

                //chartResult1.Series[series_name].ToolTip = "X value \t= #VALX\nY value \t= #VALY\nRadius";
                //chartResult1.ChartAreas["ChartArea1"].AxisX.Interval = 0.1;      

                for (int x = 0; x < sec_counter; x++)
                {

                    chartResult1.Series[series_name].Points.AddXY(x, humidity_results[x]);
                    chartResult2.Series[temp_series].Points.AddXY(x, temperature_results[x]);
                    chartResult2.Series[wet_bulb_series].Points.AddXY(x, wet_bulb_result[x]);
                    chartResult3.Series[mass_series].Points.AddXY(x, mass_results[x]);

                }

                btnStoreResult.Visible = true;
                Update7.Update();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

        private double CtoF(double Temperature)
        {
            return Temperature * 9.0 / 5 + 32.0;
        }

        private double FtoC(double Temperature)
        {
            return (Temperature - 32) * 5 / 9.0;
        }

        private double CtoK(double Temperature)
        {
            return Temperature + 273.15;
        }

        private double KtoC(double Temperature)
        {
            return Temperature - 273.15;
        }


        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoal1.Checked == true)
            {
                plhGoal1.Visible = true;
                plhGoal2.Visible = false;
                chkGoal2.Checked = false;
            }
            else
            {
                plhGoal1.Visible = false;
            }
        }

        protected void chkGoal2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoal2.Checked == true)
            {
                plhGoal1.Visible = false;
                plhGoal2.Visible = true;
                chkGoal1.Checked = false;
            }
            else
            {
                plhGoal2.Visible = false;
            }
        }


        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
                trackbar2.Maximum = 600;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {

                plhProductAdvenced.Visible = true;
            }
            else plhProductAdvenced.Visible = false;
        }

        protected void chbMachineAndGasProp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMachineAndGasProp.Checked)
            {
                string press_val = txtPressure.Text;
                plhMachineAndGasProp.Visible = true;
                txtPressure.Text = press_val;
            }
            else
            {
                string press_val = txtPressure.Text;
                plhMachineAndGasProp.Visible = false;
                txtPressure.Text = press_val;
            }
        }

        protected void btnStoreResult_Click(object sender, EventArgs e)
        {
            double desired_humidity_level = 0;
            double desired_drying_time = 0;


            if (chkGoal1.Checked)
            {
                desired_humidity_level = double.Parse(txtHumidityLevel.Text);
            }
            else
            {
                desired_drying_time = double.Parse(txtTrackTime.Text);
            }

            DataEditor de = new DataEditor();

            float des_hum_level = 0;
            int des_dry_time = 0;

            if(lblRs2DesHumLevel.Text == "n/a")
            {
                des_dry_time = int.Parse(lblRs2DesTimeOfDry.Text);
            }
            else if(lblRs2DesTimeOfDry.Text == "n/a")
            {
                des_hum_level = float.Parse(lblRs2DesHumLevel.Text);
            }

            double tmp_end_hum = double.Parse(lblRs3EndHumidity.Text);
            tmp_end_hum = Math.Round(tmp_end_hum, 2);

            try
            {
                de.AddExperimentResult(
                    int.Parse(lblRs2StartHumidity.Text),
                    float.Parse(lblRs2StartMass.Text),
                    float.Parse(lblRsVolFlowRate.Text),
                    float.Parse(lblRsHumRatio.Text) * 1000,
                    float.Parse(lblRs2DryingTemperature.Text),
                    des_hum_level,
                    des_dry_time,
                    float.Parse(lblRs2ParticleDiameter.Text),
                    lblRsGasType.Text,
                    float.Parse(lblRsInAirTemp.Text),
                    float.Parse(lblRsPressure.Text),
                    float.Parse(lblRs2HeatinRate.Text),
                    float.Parse(tmp_end_hum.ToString()),
                    float.Parse(lblRs3EndMass.Text),
                    int.Parse(lblRs3TotalTime.Text),
                    de.getUserId(lblLogin.Text)
                    );

                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('Results was successfully stored');", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

        protected void txtTrackHumidity_TextChanged(object sender, EventArgs e)
        {
            trackbar4.Maximum = int.Parse(txtTrackHumidity.Text.Trim()) - 1;   
        }

        protected void btnProdClear1_Click(object sender, EventArgs e)
        {
            txtProdMass.Text = "";
            txtTrackHumidity.Text = "";
        }

        protected void btnDryingClear_Click(object sender, EventArgs e)
        {
            ddlTempOfDry.SelectedIndex = 0;
            txtVolFlowRate.Text = "";
            txtAirHumRatio.Text = "";
            txtDryTemp.Text = "";

        }

        protected void btnProdDef_Click(object sender, EventArgs e)
        {
            txtProdParticle.Text = "200";
        }

        protected void btnProdClear2_Click(object sender, EventArgs e)
        {
            txtProdParticle.Text = "";
        }

        protected void btnGasClear_Click(object sender, EventArgs e)
        {
            txtTemperature.Text = "";
            txtPressure.Text = "";
            txtHeatingSpeed.Text = "";
            ddlStartGasTemp.SelectedIndex = 0;
        }

        protected void btnGasDef_Click(object sender, EventArgs e)
        {
            txtTemperature.Text = "20";
            txtPressure.Text = "1013,25";
            txtHeatingSpeed.Text = "2,00";
            ddlStartGasTemp.SelectedIndex = 0;
        }


    }



}

/************TIPS*****************/
//txtTimeOfDrying.BackColor = System.Drawing.ColorTranslator.FromHtml("#CCCCCC");