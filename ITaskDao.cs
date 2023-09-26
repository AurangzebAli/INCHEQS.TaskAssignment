using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace INCHEQS.TaskAssignment {
    public interface ITaskDao {
        List<TaskModel> ListAvailableTaskInGroup(string groupId);
        List<TaskModel> ListSelectedTaskInGroup(string groupId);
        List<TaskModel> ListAvailableTaskInGroupTemp(string groupId);
        List<TaskModel> ListSelectedTaskInGroupTemp(string groupId);
        void DeleteTaskNotSelected(string groupId, string taskIds);
        void DeleteTaskNotSelectedTemp(string groupId, string taskIds);
        void DeleteAllTaskInGroup(string groupId);
        bool CheckGroupExist(string groupId, string taskId);
        void UpdateSelectedTaskId(string userId, string groupId, string taskId);
        void UpdateSelectedTaskIdTemp(string userId, string groupId, string taskId);
        void InsertSelectedTaskId(string userId, string groupId, string taskId, string bankCode); //Modified Michelle 20200521
        void InsertSelectedTaskIdTemp(string userId, string groupId, string taskId, string bankCode, string Action); //Modified Michelle 20200521
        void InsertSelectedTaskIdApproval(string userId, string groupId, string taskId);
        void DeleteTaskNotSelectedApproval(string groupId, string task);
        void UpdateSelectedTaskIdApproval(string userId, string groupId, string taskId);
        void DeleteAllTaskInGroupApproval(string groupId);
        void UpdateRejectTaskIdApproval(string userId, string groupId);
        bool checkifexistinselectedtasktemp(string groupId, string taskId);
        bool CheckifGroupTaskExist(string groupId, string taskId);
        bool checkifarecorddelete(string groupId);
        bool checkfordelete2(string groupId, string taskId);
        bool CheckTaskExist(string groupId);
        DataTable ListSelectedTask(string groupId);
        void DeleteTaskTempAfterApproval(string groupId, string task);
    }
}