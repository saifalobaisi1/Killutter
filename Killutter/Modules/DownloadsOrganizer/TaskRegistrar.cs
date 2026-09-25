using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class TaskRegistrar
    {
        public static bool IsRegistered()
        {
            string taskName = "Killutter";

            using (TaskService ts = new TaskService())
            {
                Task existingTask = ts.GetTask($@"\{taskName}");

                if (existingTask != null)
                {
                    Console.WriteLine($"[FOUND] Task '{taskName}' is registered.");
                    Console.WriteLine($"Status: {existingTask.State}");
                    Console.WriteLine($"Last Run: {existingTask.LastRunTime}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"[NOT FOUND] Task '{taskName}' does not exist.");
                    return false;
                }
            }
        }

        public static void Register()
        {
            TaskDefinition td = TaskService.Instance.NewTask();
            td.RegistrationInfo.Description = "Starts Killutter";

            LogonTrigger lt = new LogonTrigger();
            lt.Delay = TimeSpan.FromMinutes(1);
            lt.UserId = WindowsIdentity.GetCurrent().Name;

            td.Triggers.Add(lt);
            td.Settings.ExecutionTimeLimit = TimeSpan.Zero;
            td.Actions.Add(Environment.ProcessPath, "c:\\test.log");

            TaskService.Instance.RootFolder.RegisterTaskDefinition("Killutter", td);
        }

        public static void Unregister()
        {

        }
    }
}
