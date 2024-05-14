using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_27
{
    public class StepInProgress
    {
        private DateTime startTime;
        private DateTime endTime;
        private Step step;
        private Order order;
        private double workTime;
        public StepInProgress(DateTime startTime, DateTime endTime, Step step, Order order, bool is_new)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.step = step;
            this.order = order;
            TimeSpan timeDifference = this.endTime - this.startTime;
           workTime = timeDifference.TotalMinutes;


            this.order.addStepInProgress(this);
            this.step.addStepInProgress(this);
   
            if (is_new)
            {
                this.create_StepInProgress();
                Program.StepInProgresses.Add(this);
            }
            
        }

     
        public DateTime get_startTime()
        {
            return this.startTime;
        }
        public DateTime get_endTime()
        {
            return this.endTime;
        }

        public Step get_Step()
        {
            return this.step;
        }

        public Order get_Order()
        {
            return this.order;
        }
        public double get_workTime()
        {
            return this.workTime;
        }

   
        public DateTime set_startTime(DateTime startTime)
        {
            this.startTime = startTime;
         
            return this.startTime;
        }
        public DateTime set_endTime(DateTime endTime)
        {
            this.endTime = endTime;
            return this.endTime;
        }
        public Step set_Step(Step step)
        {
            this.step = step;
            return this.step;
        }
        public Order set_Order(Order order)
        {
            this.order = order;
            return this.order;
        }
        public double set_workTime(double workTime)
        {
            this.workTime = workTime;
            return this.workTime;
        }
        public void create_StepInProgress()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_StepInProgress @stepname, @orderid,@starttime, @endtime";
            c.Parameters.AddWithValue("@stepname", this.step.get_stepName().ToString());
            c.Parameters.AddWithValue("@orderid", this.order.get_OrderId());
            c.Parameters.AddWithValue("@starttime", this.startTime);
            c.Parameters.AddWithValue("@endtime", this.endTime);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        
        public double CalcStandardTime(string startTime, string endTime)
        {
            this.startTime = DateTime.Parse(startTime);
            this.endTime = DateTime.Parse(endTime);
            TimeSpan timeDifference = this.endTime - this.startTime;
            double minutes = timeDifference.TotalMinutes;
            return minutes; 

        }
    }
}