using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskData
{
    public int id;
    public string type;
    public string use;
    public TaskCollection tasks;
}

public class TaskCollection
{
    public List<Task> ListOfTasks;
}

public class Task
{
    public int task_id;
    public int status; // 0 for Upcoming, 1 for InProgress, 2 for Completed
    public string title;
    public string description;
    public bool isEmergency; //true for emergency, false not
    public bool isShared;
    public string location;
    public List<int> astronauts;
    public List<Task> Subtasks;
}