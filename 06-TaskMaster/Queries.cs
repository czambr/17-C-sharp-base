using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        // Desarrollar métodos para gestionar las tareas 
        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("-------- Lista de Tareas ---------");

            Table table = new Table("Id", "Descripcion", "Estado");
            table.Config = TableConfig.Unicode();

            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
            }


            Write(table.ToString());
            ReadKey();
        }

        public List<Task> AddTasks()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---------- Anadir tarea ---------");
                Write("Ingrese la descripcion de la tarea: ");
                var description = ReadLine()!;

                Task newTask = new Task(id: Utils.GenerateId(), description: description);
                Tasks.Add(newTask);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea anadida con exito!");
                ResetColor();

                return Tasks;

            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrio un error al anadir la tarea: {ex.Message}");
                return Tasks;
            }
        }

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---------- Marcar tarea como completada ---------");
                Write("Ingrese el ID de la tarea que desea marcar como completada: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se encontro la tarea con es id: {id}");
                    ResetColor();
                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;

                WriteLine("Tarea marcada como completada con exito!");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrio un error al marcar la tarea como completada: {ex.Message}");
                return Tasks;
            }
        }

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---------- Editar tarea ---------");
                Write("Ingrese el ID de la tarea para editarla: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se encontro la tarea con es id: {id}");
                    ResetColor();
                    return Tasks;
                }

                Write("Ingrese la descripcion de la tarea: ");
                var description = ReadLine();
                task.Description = description;
                task.ModifiedAt = DateTime.Now;

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea modificada con exito!");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---------- Eliminar tarea ---------");
                Write("Ingrese el ID para eliminar la tarea: ");
                var id = ReadLine()!;

                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se encontro la tarea con es id: {id}");
                    ResetColor();
                    return Tasks;
                }

                Tasks.Remove(task);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea eliminada con exito!");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public void TasksByState()
        {
            Clear();
            try
            {
                ResetColor();

                WriteLine("---------- Buscar tarea por estado ---------");
                WriteLine("1. Completadas");
                WriteLine("2. Pendientes");

                Write("Ingrese la opcion de las tareas a mostrar: ");
                string taskState = ReadLine()!;
                if (taskState != "1" && taskState != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Opcion invalida");
                    ResetColor();
                    return;
                }

                bool completed = taskState == "1";


                List<Task> filtredTasks = Tasks.Where(t => t.Completed == completed).ToList();
                if (filtredTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontraron tareas con el estado solicitado");
                    ResetColor();
                    return;
                }

                ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;

                Table table = new Table("Id", "Descripcion", "Estado");
                table.Config = TableConfig.Unicode();

                foreach (var task in filtredTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
                }

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
            }
        }

        public void TasksByDescription()
        {
            Clear();
            try
            {
                ResetColor();

                WriteLine("---------- Buscar tarea por descripcion ---------");

                Write("Ingrese la descripcion a buscar: ");
                string taskDescription = ReadLine()!;


                List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(taskDescription, StringComparison.OrdinalIgnoreCase) ?? false);
                if (matchingTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontrarion tareas con la descripcion proporcionada.");
                    ResetColor();
                    return;
                }

                Table table = new Table("Id", "Descripcion", "Estado");
                table.Config = TableConfig.Unicode();

                foreach (var task in matchingTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
                }

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
            }
        }


    }
}
