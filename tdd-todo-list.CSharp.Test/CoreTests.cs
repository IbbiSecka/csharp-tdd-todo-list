using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using taskList;
using NUnit.Framework.Interfaces;
namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTest()
        {
            TodoList todoList = new TodoList();

            TaskObj task1 = new TaskObj("cleaning", false);
            bool result = todoList.Add(task1);


            Assert.That(result, Is.True); //Checking if added
            Assert.That(todoList.AllTasks.Count, Is.EqualTo(1));
        }
        [Test]
        public void GetAllTasks()
        {
            TodoList seeList = new TodoList();
            TaskObj task1 = new TaskObj("clean", true);
            seeList.Add(task1);

            Assert.That(seeList.AllTasks, Is.EqualTo(1));

        }



        [Test]
        public void ChangeStatusTest()
        {
            TodoList todoList = new TodoList();
            TaskObj taskClean = new TaskObj("Clean", false);

            bool currentStatus = todoList.ChangeStatus(taskClean);
            bool expectedstatus = true;

            Assert.That(currentStatus = expectedstatus);
        }
        [Test]
        public void CheckCompletedTaskReturned()
        {
            TodoList todo = new TodoList();
            TaskObj task1 = new TaskObj("cleaning", false);
            TaskObj task2 = new TaskObj("washing", true);

            todo.Add(task1);
            todo.Add(task2);

            Assert.That(todo.AllCompletedTasks.Count, Is.EqualTo(1));


        }
        [Test]
        public void CheckIncompletedTaskReturned()
        {

            TodoList todo = new TodoList();
            TaskObj task3 = new TaskObj("Jump", false);
            TaskObj task4 = new TaskObj("Sprint", false);

            todo.Add(task3);
            todo.Add(task4);

            Assert.That(todo.AllInCompletedTasks.Count, Is.EqualTo(2));
        }
        [Test]
        public void SearchTaskMessage()
        {
            TodoList todo = new TodoList();
            TaskObj taskExists = new TaskObj("Hei", true);
            TaskObj taskExistsNa = new TaskObj("Nei", false);

            todo.Add(taskExists);

            string expectedString = "Task doesnt exist in the list";
            string result = todo.SearchForTask(taskExistsNa);

            Assert.That(expectedString == result);
        }
        [Test]
        public void TaskIsRemoved()
        {
            TodoList todo = new TodoList();
            TaskObj task1 = new TaskObj("journaling", true);
            TaskObj task2 = new TaskObj("reading", false);

            todo.Add(task1);
            todo.Add(task2);

            int result = todo.removeTask(task1);
            int expectedResult = 1;

            Assert.That(expectedResult == result);
        }
        [Test]
        public void ascendingOrderList()
        {
            TodoList todo = new TodoList();
            TaskObj task1 = new TaskObj("attend meeting", true);
            TaskObj task2 = new TaskObj("clean", true);

            todo.Add(task1);
            todo.Add(task2);
            List<TaskObj> tasks = todo.AllTasks;
            List<TaskObj> sortedTodo = todo.Ascend(tasks);

            Assert.AreEqual("attend meeting", sortedTodo[0].TaskName);

        }
        [Test]
        public void descendingOrderList()
        {
            
            TodoList todo = new TodoList();
            TaskObj task1 = new TaskObj("attend meeting", true);
            TaskObj task2 = new TaskObj("clean", true);

            todo.Add(task1);
            todo.Add(task2);

            List<TaskObj> tasks = todo.AllTasks;

            
            List<TaskObj> sortedTodo = todo.Descend(tasks);

            
            Assert.AreEqual("clean", sortedTodo[0].TaskName);

        }
    }
}