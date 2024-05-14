using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_27
{
    public class Step
    {
        private StepName stepName;
        private double standardTime;
        private double standardDeviation;
        public List<StepInProgress> StepsInProgress;




        public Step(StepName stepName, double standardTime, double standardDeviation, bool is_new)
        {
            this.stepName = stepName;
            this.standardTime = standardTime; // לסדר זמן סיום פחות זמן התחלה
            this.standardDeviation = 0; //השונות של תצפית אחת היא 0
            this.StepsInProgress = new List<StepInProgress>();
            if (is_new)
            {
                this.create_Step();
                Program.Steps.Add(this);
            }
            
        }
        public StepName get_stepName()
        {
            return this.stepName;
        }
        public double get_standardTime()
        {
            return this.standardTime;
        }
        public double get_standardDeviation()
        {
            return this.standardDeviation;
        }
        public StepName set_stepName(StepName stepName)
        {
            this.stepName = stepName;
            return this.stepName;
        }
        public double set_standardTime(double standardTime)
        {
            this.standardTime = standardTime;
            return this.standardTime;
        }
        public double set_standardDeviation(double standardDeviation)
        {
            this.standardDeviation = standardDeviation;
            return this.standardDeviation;

        }

        public void Update_Step(string stepName)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Step @StepName ,@StandardTime ,@StandardDeviation ";
            c.Parameters.AddWithValue("@StepName", this.stepName.ToString());
            c.Parameters.AddWithValue("@StandardTime", this.standardTime);
            c.Parameters.AddWithValue("@StandardDeviation", this.standardDeviation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void create_Step()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Step @StepName ,@StandardTime ,@StandardDeviation ";
            c.Parameters.AddWithValue("@StepName", this.stepName.ToString());
            c.Parameters.AddWithValue("@StandardTime", this.standardTime);
            c.Parameters.AddWithValue("@StandardDeviation", this.standardDeviation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_StandradTime_Step(string stepName,double standardTime)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_StandardTime_Step @StepName, @StandardTime";
            c.Parameters.AddWithValue("@StepName", stepName.ToString());
            c.Parameters.AddWithValue("@StandardTime", standardTime);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Update_STDV_Step(string stepName, double STDV)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_STDV_Step @StepName, @StandardDeviation";
            c.Parameters.AddWithValue("@StepName", stepName.ToString());
            c.Parameters.AddWithValue("@StandardDeviation", STDV);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void addStepInProgress(StepInProgress sip)
        {
            this.StepsInProgress.Add(sip);
        }
    }
}