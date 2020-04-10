using System;
using System.Collections.Generic;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList task_course = new Task("20 minutes de course");
            TodoList task_pompesIncliné = new Task("20 Pompes Inclinée");
            TodoList task_dips = new Task("30 dips");
            TodoList task_abdo = new Task("40 Abdo");
            
            TodoList project_pompe = new Project("Pompes", new []{task_pompesIncliné, task_dips});
            TodoList project_musculation = new Project("Musculation", new []{project_pompe, task_abdo});
            TodoList project_cardio = new Project("Cardio", new []{task_course});
            TodoList project_sport = new Project("Sport", new []{project_musculation, project_cardio});

            Console.WriteLine("Confinement TodoList");
            Console.WriteLine(project_sport.getHtml());
        }
    }
}
