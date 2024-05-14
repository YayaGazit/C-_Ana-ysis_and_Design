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
        private DateTime date;
        private DateTime startTime;
        private DateTime endTime;
        public Step step;
        public Order order;

        public StepInProgress(DateTime date, DateTime startTime, DateTime endTime, Step step, Order order, bool is_new)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.step = step;
            this.order = order;
            if (is_new)
            {
                this.create_StepInProgress();
                Program.StepInProgresses.Add(this);
            }

        }
        public void create_StepInProgress()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_StepInProgress @date, @startTime, @endTime,@step,@order";
            c.Parameters.AddWithValue("@date", this.date);
            c.Parameters.AddWithValue("@startTime", this.startTime);
            c.Parameters.AddWithValue("@endTime", this.endTime);
            c.Parameters.AddWithValue("@requirements", this.step.ToString());
            c.Parameters.AddWithValue("@status", this.order.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Update_StepInProgress(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_StepInProgress @date, @startTime, @endTime,@step,@order";
            c.Parameters.AddWithValue("@date", this.date);
            c.Parameters.AddWithValue("@startTime", this.startTime);
            c.Parameters.AddWithValue("@endTime", this.endTime);
            c.Parameters.AddWithValue("@requirements", this.step.ToString());
            c.Parameters.AddWithValue("@status", this.order.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}