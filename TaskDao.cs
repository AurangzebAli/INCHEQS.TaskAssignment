using INCHEQS.Common;
using INCHEQS.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace INCHEQS.TaskAssignment {
    public class TaskDao : ITaskDao {

        private readonly ApplicationDbContext dbContext;

        public TaskDao(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<TaskModel> ListAvailableTaskInGroup(string groupId)
        {
            DataTable dataTable = new DataTable();
            List<TaskModel> taskModels = new List<TaskModel>();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgAvailableTaskInGroup", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    TaskModel taskModel = new TaskModel()
                    {
                        fldTaskId = row["fldTaskId"].ToString(),
                        fldTaskDesc = row["fldTaskDesc"].ToString()
                    };
                    taskModels.Add(taskModel);
                }
            }
            return taskModels;
        }

        public List<TaskModel> ListSelectedTaskInGroup(string groupId)
        {
            DataTable dataTable = new DataTable();
            List<TaskModel> taskModels = new List<TaskModel>();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgSelectedTaskInGroup", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    TaskModel taskModel = new TaskModel()
        {
                        fldTaskId = row["fldTaskId"].ToString(),
                        fldTaskDesc = row["fldTaskDesc"].ToString()
                    };
                    taskModels.Add(taskModel);
                }
            }
            return taskModels;
        }

        public List<TaskModel> ListAvailableTaskInGroupTemp(string groupId)
        {
            DataTable dataTable = new DataTable();
            List<TaskModel> taskModels = new List<TaskModel>();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgAvailableTaskInGroupTemp", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
            {
                    TaskModel taskModel = new TaskModel()
                {
                        fldTaskId = row["fldTaskId"].ToString(),
                        fldTaskDesc = row["fldTaskDesc"].ToString()
                    };
                    taskModels.Add(taskModel);
                }
            }
            return taskModels;
        }

        public List<TaskModel> ListSelectedTaskInGroupTemp(string groupId)
        {
            DataTable dataTable = new DataTable();
            List<TaskModel> taskModels = new List<TaskModel>();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgSelectedTaskInGroupTemp", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    TaskModel taskModel = new TaskModel()
                    {
                        fldTaskId = row["fldTaskId"].ToString(),
                        fldTaskDesc = row["fldTaskDesc"].ToString()
                    };
                    taskModels.Add(taskModel);
                }
            }
            return taskModels;
        }

        public DataTable ListSelectedTask(string groupId)
        {
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));

            return this.dbContext.GetRecordsAsDataTableSP("spcgSelectedTask", sqlParameterNext.ToArray());
        }

        public bool checkfordelete2(string groupId, string taskId)
            {
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgForDelete2", sqlParameterNext.ToArray());
            
            if (dataTable.Rows.Count == 0)
                {
                return true;
                }
            else
            {
                return false;
            }
        }

        public bool checkifexistinselectedtasktemp(string groupId, string taskId)
        {
            bool strs = false;
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgIfExistInSelectedTaskTemp", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                strs = true;
            }
            else
            {
                strs = false;
        }

            return strs;
        }

        public bool CheckifGroupTaskExist(string groupId, string taskId)
        {
            bool strs = false;
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgIfGroupTaskExist", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                strs = true;
            }
            else
            {
                strs = false;
            }

            return strs;
        }
        public bool CheckTaskExist(string groupId)
        {
            bool strs = false;
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgTaskExist", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
        {
                strs = true;
            }
            else
            {
                strs = false;
            }

            return strs;
        }

        public bool CheckGroupExist(string groupId, string taskId)
        {
            bool strs = false;
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgGroupExist", sqlParameterNext.ToArray());

            if (dataTable.Rows.Count > 0)
            {
                strs = true;
            }
            else
            {
                strs = false;
        }

            return strs;
        }
        public bool checkifarecorddelete(string groupId)
        {
            DataTable dataTable = new DataTable();
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dataTable = dbContext.GetRecordsAsDataTableSP("spcgIfARecordDelete", sqlParameterNext.ToArray());
            
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteTaskNotSelected(string groupId, string taskIds)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            string[] strArrays = taskIds.Split(new char[] { ',' });
            string idString = String.Join(",", strArrays);

            if (strArrays.Length != 0)
            {
                sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
                sqlParameterNext.Add(new SqlParameter("@TaskIds", idString));
                this.dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcdTaskNotSelected", sqlParameterNext.ToArray());
            }
        }

        public void DeleteTaskNotSelectedTemp(string groupId, string taskIds)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            string[] strArrays = taskIds.Split(new char[] { ',' });
            string idString = String.Join(",", strArrays);

            if (strArrays.Length != 0)
            {
                sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
                sqlParameterNext.Add(new SqlParameter("@TaskIds", idString));
                this.dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcdTaskNotSelectedTemp", sqlParameterNext.ToArray());
            }

        }

        public void DeleteAllTaskInGroup(string groupId)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            try
            {
                sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
                this.dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcdAllTaskInGroup", sqlParameterNext.ToArray());
        }
            catch (Exception exception)
        {
                throw exception;
            }
        }

        public void DeleteAllTaskInGroupApproval(string groupId)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            try
            {
                sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
                this.dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcdAllTaskInGroupApproval", sqlParameterNext.ToArray());
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void UpdateSelectedTaskId(string userId, string groupId, string taskId)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            sqlParameterNext.Add(new SqlParameter("@fldApproved", "Y"));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcuSelectedTaskId", sqlParameterNext.ToArray());
        }

        public void UpdateSelectedTaskIdTemp(string userId, string groupId, string taskId)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            sqlParameterNext.Add(new SqlParameter("@fldApproved", "Y"));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcuSelectedTaskIdTemp", sqlParameterNext.ToArray());
        }

        public void InsertSelectedTaskId(string userId, string groupId, string taskId, string bankCode)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
            sqlParameterNext.Add(new SqlParameter("@fldCreateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldCreateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldBankCode", bankCode));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spciSelectedTaskId", sqlParameterNext.ToArray());
        }

        public void InsertSelectedTaskIdTemp(string userId, string groupId, string taskId, string bankCode, string Action)
        {
            if (Action == "CreateA")
            {
                List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
                sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
                sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
                sqlParameterNext.Add(new SqlParameter("@fldBankCode", bankCode));
                sqlParameterNext.Add(new SqlParameter("@fldCreateUserId", userId));
                sqlParameterNext.Add(new SqlParameter("@fldCreateTimeStamp", (object)DateTime.Now));
                sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
                sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
                sqlParameterNext.Add(new SqlParameter("@fldApproved", "S"));
                sqlParameterNext.Add(new SqlParameter("@Action", "CreateA"));
                dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spciSelectedTaskIdTemp", sqlParameterNext.ToArray());
            }
            else if (Action == "CreateD")
            {
                List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
                sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
                sqlParameterNext.Add(new SqlParameter("@fldTaskId", taskId));
                sqlParameterNext.Add(new SqlParameter("@fldBankCode", bankCode));
                sqlParameterNext.Add(new SqlParameter("@fldCreateUserId", userId));
                sqlParameterNext.Add(new SqlParameter("@fldCreateTimeStamp", (object)DateTime.Now));
                sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
                sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
                sqlParameterNext.Add(new SqlParameter("@fldApproved", "U"));
                sqlParameterNext.Add(new SqlParameter("@Action", "CreateD"));
                dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spciSelectedTaskIdTemp", sqlParameterNext.ToArray());
            }
        }

        //approvedtaskchecker
        public void DeleteTaskNotSelectedApproval(string groupId, string task)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", task));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcdTaskNotSelectedApproval", sqlParameterNext.ToArray());
        }

        public void UpdateRejectTaskIdApproval(string userId, string groupId)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldApproved", "Y"));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcuRejectTaskIdApproval", sqlParameterNext.ToArray());
        }

        public void UpdateSelectedTaskIdApproval(string userId, string groupId, string task)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", task));
            sqlParameterNext.Add(new SqlParameter("@fldApproved", "Y"));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcuSelectedTaskIdApproval", sqlParameterNext.ToArray());
        }

        public void InsertSelectedTaskIdApproval(string userId, string groupId, string task)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldUpdateUserId", userId));
            sqlParameterNext.Add(new SqlParameter("@fldUpdateTimeStamp", (object)DateTime.Now));
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", task));
            sqlParameterNext.Add(new SqlParameter("@fldApproved", "Y"));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spciSelectedTaskIdApproval", sqlParameterNext.ToArray());
        }
        public void DeleteTaskTempAfterApproval(string groupId, string task)
        {
            List<SqlParameter> sqlParameterNext = new List<SqlParameter>();
            sqlParameterNext.Add(new SqlParameter("@fldGroupId", groupId));
            sqlParameterNext.Add(new SqlParameter("@fldTaskId", task));
            dbContext.ExecuteNonQuery(CommandType.StoredProcedure, "spcdTaskTempAfterApproval", sqlParameterNext.ToArray());
        }

    }
}