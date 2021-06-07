using System;
using System.Collections.Generic;

public class Support
{
    private readonly List<Task> tasks = new List<Task>();

    public IEnumerable<Task> Tasks => tasks;

    public int OpenTask(string text)
    {

    }

    public void CloseTask(int id, string answer)
    {
        
    }

    public List<Task> GetAllUnresolvedTasks()
    {

    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        
    }

    public string GetTaskInfo(int id)
    {

    }
}