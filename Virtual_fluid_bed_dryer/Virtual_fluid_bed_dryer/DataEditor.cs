using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Virtual_fluid_bed_dryer
{
    public class DataEditor
    {

        //Returs list of users, qith specific Login (just one allowed)
        public static List<User> GetUserByName(string Login)
        {
            UsersDataContext context = new UsersDataContext();

            return (from user in context.Users
                    where user.Login == Login
                    select user).ToList();
        }

        public static User GetUserByEmail(string email)
        {
            UsersDataContext context = new UsersDataContext();

            return (from user in context.Users
                    where user.Email == email
                    select user).ToList()[0];
        }


        //Method for adding new user to DB
        public void AddUser(string Login, string Password, string Email, string GUID)
        {

            //Adding row to Users table for new user
            UsersDataContext context = new UsersDataContext();
            User new_user = new User();

            new_user.Login = Login;
            new_user.Password = Password;
            new_user.Email = Email;
            new_user.Confirmed = false;
            new_user.RegistrationDate = DateTime.Now.Date;

            context.Users.InsertOnSubmit(new_user);
            context.SubmitChanges();


            //Adding row to RegistrationInformation table for new_user
            RegistrationInformationsDataContext reg_context = new RegistrationInformationsDataContext();
            RegistrationInformation reg_info = new RegistrationInformation();

            reg_info.GUID = GUID;
            reg_info.DaysLeft = 7;
            reg_info.UserId = new_user.Id;

            reg_context.RegistrationInformations.InsertOnSubmit(reg_info);
            reg_context.SubmitChanges();
        }

        //Checking if login already present in DB
        public static bool isLoginPresent(string login)
        {
            UsersDataContext users_context = new UsersDataContext();
            List<User> lst_user = new List<User>();

            lst_user = (from user in users_context.Users
                       where user.Login == login
                       select user).ToList();

            if (lst_user.Count != 0) return true;
            else return false;
            
        }

        //Checking if email already present in DB
        public bool isEmailPresent(string email)
        {
            UsersDataContext users_context = new UsersDataContext();
            List<User> lst_user = new List<User>();

            lst_user = (from user in users_context.Users
                        where user.Email == email
                        select user).ToList();

            if (lst_user.Count != 0) return true;
            else return false;
        }

        //Checking if proper password was given
        public static bool isPasswordMatch(string login, string password)
        {
            UsersDataContext users_context = new UsersDataContext();
            User tmp_user = new User();

            tmp_user = ((from user in users_context.Users
                        where user.Login == login
                        select user).ToList())[0];

            if (tmp_user.Password == password) return true;
            else return false;
        }


        //This method delete row in Registration information table after successful confirmation
        //-Return user id 
        public int deleteRowByGuid(string guid)
        {

            RegistrationInformationsDataContext reg_context = new RegistrationInformationsDataContext();
            RegistrationInformation reg_info = new RegistrationInformation();

            reg_info = ((from reginfo in reg_context.RegistrationInformations
                    where reginfo.GUID == guid
                    select reginfo).ToList())[0];
            int user_id = reg_info.UserId;

            reg_context.RegistrationInformations.DeleteOnSubmit(reg_info);
            reg_context.SubmitChanges();

            return user_id;
        }


        //Method to change registraion confirmation indicator in user table
        public void confirmRegistration(int id_user)
        {
            UsersDataContext user_context = new UsersDataContext();
            User user_edit = new User();

            user_edit = ((from user in user_context.Users
                    where user.Id == id_user
                    select user).ToList())[0];

            user_edit.Confirmed = true;
            user_context.SubmitChanges();
        }

        //Method to change user email address
        public void changeUserEmail(string login, string new_email)
        {
            UsersDataContext user_context = new UsersDataContext();
            User user_edit = new User();

            user_edit = ((from user in user_context.Users
                          where user.Login == login
                          select user).ToList())[0];

            user_edit.Email = new_email;
            user_context.SubmitChanges();
        }

        //Method to change user password
        public void changeUserPassword(string login, string new_password)
        {
            UsersDataContext user_context = new UsersDataContext();
            User user_edit = new User();

            user_edit = ((from user in user_context.Users
                          where user.Login == login
                          select user).ToList())[0];

            user_edit.Password = new_password;
            user_context.SubmitChanges();
        }

        //Checking if user acount was confirmed after reagitration
        public bool isConfirmed(string login)
        {
            UsersDataContext user_context = new UsersDataContext();
            User user_edit = new User();

            user_edit = ((from user in user_context.Users
                          where user.Login == login
                          select user).ToList())[0];

            if (user_edit.Confirmed) return true;
            else return false;
        }

        //Returns User id
        public int getUserId(string login)
        {
            UsersDataContext user_context = new UsersDataContext();
            User user_edit = new User();

            return ((from user in user_context.Users
                          where user.Login == login
                          select user).ToList())[0].Id;
        }

        //Checking if given GUID is already present in DB
        //Security purpose
        public bool isGuidPresent(string guid)
        {
            RegistrationInformationsDataContext reg_context = new RegistrationInformationsDataContext();
            List<RegistrationInformation> lst_reg = new List<RegistrationInformation>();

            lst_reg = (from reginfo in reg_context.RegistrationInformations
                       where reginfo.GUID == guid
                       select reginfo).ToList();

            if (lst_reg.Count != 0) return true;
            else return false;
        }


        //Method for adding new experiment result to DB
        public void AddExperimentResult(int start_humidity, float mass, float volume_flow_rate, float humidity_ratio, float drying_temp, float desired_hum_level, int time_of_drying,
            float particle_diameter, string gas_type, float start_gas_temp, float pressure, float machine_heating_rate, float product_final_hum, float product_final_mass, int total_time, int user_id)
        {

            ExperimentResultDataContext context = new ExperimentResultDataContext();
            ExperimentResult exp_res = new ExperimentResult();

            exp_res.Start_humidity = start_humidity;
            exp_res.Mass = mass;
            exp_res.Volume_flow_rate = volume_flow_rate;
            exp_res.Humidity_ratio = humidity_ratio;
            exp_res.Drying_temperature = drying_temp;
            exp_res.Desired_humidity_level = desired_hum_level;
            exp_res.Time_of_drying = time_of_drying;
            exp_res.Particle_diameter = particle_diameter;
            exp_res.Gas_type = gas_type;
            exp_res.Start_gas_temperature = start_gas_temp;
            exp_res.Pressure = pressure;
            exp_res.Machine_heating_rate = machine_heating_rate;
            exp_res.Product_final_hum = product_final_hum;
            exp_res.Product_fianl_mass = product_final_mass;
            exp_res.Total_time = total_time;
            exp_res.Experiment_date = DateTime.Now.Date;
            exp_res.User_id = user_id;

            context.ExperimentResult.InsertOnSubmit(exp_res);
            context.SubmitChanges();
        }

        //Returns Experiment Result with specified Id
        public static ExperimentResult GetExpById(int exp_id)
        {
            ExperimentResultDataContext context = new ExperimentResultDataContext();
            
            return ((from exps in context.ExperimentResult
                    where exps.Id == exp_id
                    select exps).ToList())[0];
        }

    }
}