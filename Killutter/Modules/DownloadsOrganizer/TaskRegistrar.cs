using Killutter.Shared;
using Microsoft.Win32.TaskScheduler;
using System.Security.Principal;
using ScheduledTask = Microsoft.Win32.TaskScheduler.Task;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class TaskRegistrar
    {
        public static bool IsRegistered()
        {
            ScheduledTask existingTask = TaskService.Instance.GetTask("Killutter");

            if (existingTask == null)
            {
                Logger.Log(LogLevel.Info, "Task 'Killutter' is not registered.");
                return false;
            }

            if (!existingTask.Definition.Triggers.Any(t => t is LogonTrigger))
            {
                Logger.Log(LogLevel.Warning, "Task 'Killutter' exists but has no LogonTrigger.");
                return false;
            }

            if (!existingTask.Definition.Actions.OfType<ExecAction>().Any())
            {
                Logger.Log(LogLevel.Warning, "Task 'Killutter' exists but has no ExecAction.");
                return false;
            }

            if (!existingTask.Definition.Settings.Enabled)
            {
                Logger.Log(LogLevel.Warning, "Task 'Killutter' exists but is disabled.");
                return false;
            }

            Logger.Log(LogLevel.Info, $"Task 'Killutter' is registered and valid. Status: {existingTask.State}, Last Run: {existingTask.LastRunTime}");
            return true;
        }

        public static void Register()
        {
            TaskDefinition td = TaskService.Instance.NewTask();
            td.RegistrationInfo.Description = "Starts Killutter";

            LogonTrigger lt = new LogonTrigger();
            lt.Delay = TimeSpan.FromMinutes(1);
            lt.UserId = WindowsIdentity.GetCurrent().Name;
            td.Principal.LogonType = TaskLogonType.InteractiveToken;

            td.Triggers.Add(lt);
            td.Settings.ExecutionTimeLimit = TimeSpan.Zero;
            td.Actions.Add(Environment.ProcessPath);

            TaskService.Instance.RootFolder.RegisterTaskDefinition("Killutter", td);
        }

        public static bool UnRegister()
        {
            ScheduledTask existingTask = TaskService.Instance.GetTask("Killutter");

            if (existingTask == null)
            {
                Logger.Log(LogLevel.Info, "Task 'Killutter' was not registered, nothing to unregister.");
                return false;
            }

            try
            {
                TaskService.Instance.RootFolder.DeleteTask("Killutter");
                Logger.Log(LogLevel.Info, "Task 'Killutter' unregistered.");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, $"Failed to unregister task 'Killutter': {ex.Message}");
                return false;
            }
        }
    }
}
